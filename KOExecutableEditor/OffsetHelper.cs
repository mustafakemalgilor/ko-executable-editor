/**
 * ______________________________________________________
 * This file is part of ko-executable-editor project.
 * 
 * @author       Mustafa Kemal Gılor <mustafagilor@gmail.com> (2016)
 * .
 * SPDX-License-Identifier:	MIT
 * ______________________________________________________
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
// ReSharper disable All

namespace KOExecutableEditor
{
    internal class OffsetHelper
    {

        #region Definition

        private static readonly byte[] HttpPattern = new byte[] {0x68, 0x74, 0x74, 0x70, 0x3A, 0x2F, 0x2F};
        private static byte[] httpsPattern = new byte[] {0x68, 0x74, 0x74, 0x70, 0x73, 0x3A, 0x2F, 0x2F};

        // CMP EAX,0xB7
        private static byte[] mutexErrorPattern = new byte[] { 0x3D, 0xB7, 0x00, 0x00, 0x00 };



        private List<byte[]> LeaPatterns = new List<byte[]>()
        {
            new byte[]{0x0C, 0xCD},   // LEA ECX, ECX * 8
            new byte[]{0x14, 0xD5},   // LEA EDX, EDX * 8
            new byte[]{0x84, 0x08},   // LEA EAX, EAX + ECX
            new byte[]{0x8C, 0x09} ,  // LEA ECX, ECX + ECX
            new byte[]{0x8C, 0x00},   // LEA ECX, EAX + EAX
            new byte[]{0x94, 0x02} ,  // LEA EDX, EDX + EAX
            new byte[]{0x9C, 0x0B} ,  // LEA EBX, EBX + ECX
        };


    enum Opcodes : byte
        {
            PUSH = 0x68,
            LEA  = 0x8D,
        }

        enum JmpShort : byte
        {
            JO = 0x70,  // Jump if overflow         (OF = 1)
            JNO = 0x71, // Jumo if not overflow     (OF = 0)
            JS = 0x78,  // Jump if sign             (SF = 1)
            JNS = 0x79, // Jump if not sign         (SF = 0)
            JE = 0x74,  // Jump if equal            (ZF = 1)
            JNE = 0x75, // Jump if not equal        (ZF = 0)
            JB = 0x72,  // Jump if below            (CF = 1)
            JNB = 0x73, // Jump if not below        (CF = 0)
            JBE = 0x76, // Jump if below or equal   (CF = 1 or ZF = 1)
            JA = 0x77,  // Jump if above            (CF = 0 and ZF = 0)
            JL = 0x7C,  // Jump if less             (SF <> OF)
            JGE = 0x7D, // Jump if greater or equal (SF = OF)
            JLE = 0x7E, // Jump if less or equal    (ZF = 1 or SF<>OF)
            JG = 0x7F,  // Jump if greater          (ZF = 0 and SF = OF)
            JP = 0x7A,  // Jump if parity even      (PF = 1)
            JNP = 0x7B, // Jump if parity odd       (PF = 0)
            JXCZ = 0xE3 // Jump if ECX is 0         (ECX = 0)
        }

        enum MovOpcodes : byte
        {
            EAX = 0xB8,
            ECX = 0xB9,
            EDX = 0xBA,
            EBX = 0xBB,
            ESP = 0xBC,
            EBP = 0xBD,
            ESI = 0xBE,
            EDI = 0xBF
        }

        enum CompareOpcodes : byte
        {
              /* Compare immediate byte to register/memory byte */
              BYTE = 0x80,
              /* Compare immediate word to register/memory byte */
              WORD = 0x81,
              /* Compare immediate dword to register/memory byte */
              DWORD = 0x83,
              /* Compare register/memory byte to byte register */
              RBYTE = 0x3A,
              /* Compare register/memory (dword to dword) or (word to word) register */
              RWORDDWORD = 0x3B,
              /* Compare immediate byte to AL */
              IBYTEAL = 0x3C,
              /* Compare immediate word to AX or Compare immediate dword to EAX */
              IWORDDWORDEAX = 0x3D
        }

        enum CompareSubOpcodes : byte
        {
            EAX = 0xF8,
            ECX = 0xF9,
            EDX = 0xFA,
            EBX = 0xFB,
            ESP = 0xFC,
            EBP = 0xFD,
            ESI = 0xFE,
            EDI = 0xFF
        }

        public static bool CompareArray(byte[] arr1, int srcIndex, byte[] arr2, int dstIndex, int len)
        {
            for (int i = 0; i < len; i++)
            {
                if (arr1[srcIndex + i] != arr2[dstIndex + i])
                    return false;
            }
            return true;
        }

        #endregion

        #region Offset finding

        public int FindMutex(byte[] buf)
        {
            int index = 0;
            var arr = new byte[mutexErrorPattern.Length];
            while (true)
            {
                /* Check EOF */
                if (buf.Length - index <= mutexErrorPattern.Length)
                    return 0;
                Array.Copy(buf, index++, arr, 0, mutexErrorPattern.Length);
                if (CompareArray(arr, 0, mutexErrorPattern, 0, mutexErrorPattern.Length))
                    /* CMP EAX, 0xB7  // 5 bytes
                     * JE ....        // The instruction that we're interested in
                     */
                    return (index - 1) + 5;
            }
        }

        /*
         * @brief 
         *      Searches for strings starting with http:// and https:// in given buffer.
         * @params
         *      byte[] buf - the buffer which the string(s) will be searched in.
         * @returns
         *      A dictionary containing string offsets and string itself.
         *      
         */
        public Dictionary<int, string> FindURLs(byte[] buf)
        {
            Dictionary<int,string> URLs = new Dictionary<int, string>();
            int index = 0;
            int foundOffset = 0;  
            // TODO : Merge http and https loops.
            // http://
            while (true)
            {
                var arr = new byte[HttpPattern.Length];
                if (buf.Length - index <= HttpPattern.Length)
                {
                    break;
                }
                Array.Copy(buf, index++, arr, 0, HttpPattern.Length);
                var indx = 0;
                while (true)
                {
                    if (indx == HttpPattern.Length)
                    {
                        foundOffset = index - 1;
                        byte cur = 0xFF;
                        List<byte> val = new List<byte>();
                        int itr = 0;
                        while (cur != 0x00)
                        {
                            cur = buf[index - 1 + itr++];
                            val.Add(cur);
                        }
                        URLs.Add(foundOffset,Encoding.ASCII.GetString(val.ToArray()));
                        break;
                    }
                    if (arr[indx] == HttpPattern[indx])
                    {
                        indx++;
                    }
                    else
                        break;
                }
            }

            index = 0;
            foundOffset = 0;
            // https://
            while (true)
            {
                var arr = new byte[httpsPattern.Length];
                if (buf.Length - index <= httpsPattern.Length)
                {
                    return URLs;
                }
                Array.Copy(buf, index++, arr, 0, httpsPattern.Length);
                var indx = 0;
                while (true)
                {
                    if (indx == httpsPattern.Length)
                    {
                        foundOffset = index - 1;
                        byte cur = 0xFF;
                        List<byte> val = new List<byte>();
                        int itr = 0;
                        while (cur != 0x00)
                        {
                            cur = buf[index - 1 + itr++];
                            val.Add(cur);
                        }
                        URLs.Add(foundOffset, Encoding.ASCII.GetString(val.ToArray()));
                        break;
                    }
                    if (arr[indx] == httpsPattern[indx])
                    {
                        indx++;
                    }
                    else
                        break;
                }
            }
        }

        /*
        * @brief 
        *      Searches for any MOV RA, value signature in given buffer
         *     RA = All registers(EAX,ECX,..,EDI)
        * @returns
        *      Nonzero if a value found, otherwise zero.
        *      
        */
        public int FindVersion_Display(byte[] buf, String value)
        {
            byte curOp = (byte)MovOpcodes.EAX;
            check_again:
            UInt32 ui32 = Convert.ToUInt32(value);
            byte[] val = BitConverter.GetBytes(ui32);
            var arrCmp1 = new[] { curOp, val[0], val[1], val[2], val[3] };
            int index = 0;
            int foundOffset = 0;
            while (true)
            {
                var arr = new byte[arrCmp1.Length];

                /* Check EOF */
                if (buf.Length - index <= arrCmp1.Length)
                {
                    if (foundOffset == 0 && curOp != (int) MovOpcodes.EDI)
                    {
                        curOp++;
                        goto check_again;
                    }
                    return foundOffset;
                }

                Array.Copy(buf, index++, arr, 0, arrCmp1.Length);
                var indx = 0;
                while (true)
                {
                    if (indx == arrCmp1.Length)
                    {
                        foundOffset = index - 1;
                        break;
                    }
                    if (arr[indx] == arrCmp1[indx])
                    {
                        indx++;
                    }
                    else
                        break;
                }

            }
        }

        /*
        * @brief 
        *      Searches for any CMP RA,VALUE signature in the given buffer.
        * @returns
        *      Nonzero if a value matches, zero if not.
        *      
        */
        public int FindVersion_Original2(byte[] buf, String value)
        {
            
            UInt32 ui32 = Convert.ToUInt32(value);
            byte[] val = BitConverter.GetBytes(ui32);
            var arrCmp1 = new[] { (byte)CompareOpcodes.IWORDDWORDEAX, val[0], val[1], val[2], val[3] };
            int index = 0;
            int foundOffset = 0;
            while (true)
            {
                var arr = new byte[arrCmp1.Length];

                /* Check EOF */
                if (buf.Length - index <= arrCmp1.Length)
                    return foundOffset;

                Array.Copy(buf, index++, arr, 0, arrCmp1.Length);
                var indx = 0;
                while (true)
                {
                    if (indx == arrCmp1.Length)
                    {
                        foundOffset = index - 1;
                        break;
                    }
                    if (arr[indx] == arrCmp1[indx])
                    {
                        indx++;
                    }
                    else
                        break;
                }

            } 
        }

        /*
      * @brief 
      *      Searches for any CMP RA,VALUE signature. (WORD)
       *     RA = All registers(EAX,ECX,..,EDI)
      * @returns
      *      Nonzero if a value found, otherwise zero.
      *      
      */
        public int FindVersion_Original(byte[] buf, String value)
        {
            byte curOp = (byte) CompareSubOpcodes.EAX;
            check_again:
            UInt32 ui32 = Convert.ToUInt32(value);
            byte[] val = BitConverter.GetBytes(ui32);
            var arrCmp1 = new[] { (byte)CompareOpcodes.WORD, curOp, val[0], val[1], val[2], val[3] };
            int index = 0;
            int foundOffset = 0;
            while (true)
            {
                var arr = new byte[arrCmp1.Length];

                /* Check EOF */
                if (buf.Length - index <= arrCmp1.Length)
                {
                    if (foundOffset == 0 && curOp != (byte)CompareSubOpcodes.EDI)
                    {
                        curOp++;
                        goto check_again;
                        
                       
                    }
                    else if(foundOffset == 0 && curOp == (byte)CompareSubOpcodes.EDI)
                        return FindVersion_Original2(buf, value);
                    return foundOffset;
                }

                Array.Copy(buf, index++, arr, 0, arrCmp1.Length);
                var indx = 0;
                while (true)
                {
                    if (indx == arrCmp1.Length)
                    {
                        foundOffset = index - 1;
                        break;
                    }
                    if (arr[indx] == arrCmp1[indx])
                    {
                        indx++;
                    }
                    else
                        break;
                }

            }
        }
        public List<int> FindPort(byte[] buf, String value)
        {
            List<int> offsetList = new List<int>();
            UInt32 ui32 = Convert.ToUInt32(value);
            byte[] val = BitConverter.GetBytes(ui32);
            var arrCmp1 = new[] { (byte)Opcodes.PUSH, val[0], val[1], val[2], val[3] };
            int index = 0;
            while (true)
            {
                var arr = new byte[arrCmp1.Length];

                /* Check EOF */
                if (buf.Length - index <= arrCmp1.Length)
                    return offsetList;

                Array.Copy(buf, index++, arr, 0, arrCmp1.Length);
                var indx = 0;
                while (true)
                {
                    if (indx == arrCmp1.Length)
                    {
                        offsetList.Add(index - 1);
                        break;
                    }
                    if (arr[indx] == arrCmp1[indx])
                    {
                        indx++;
                    }
                    else
                        break;
                }

            }
        }


        public List<int> FindTBLKey1_Pattern3(byte[] buf, String value)
        {
            var offsetList = new List<int>();
            foreach (byte[] leaPattern in LeaPatterns)
            {

                var ui32 = Convert.ToUInt32(value, 16);
                var val = BitConverter.GetBytes(ui32);
                var arrCmp1 = new[] {(byte) Opcodes.LEA, leaPattern[0], leaPattern[1], val[0], val[1], val[2], val[3]};
                var index = 0;
                while (true)
                {
                    var arr = new byte[arrCmp1.Length];

                    /* Check EOF */
                    if (buf.Length - index <= arrCmp1.Length)
                        break;


                    Array.Copy(buf, index++, arr, 0, arrCmp1.Length);
                    var indx = 0;
                    while (true)
                    {
                        if (indx == arrCmp1.Length)
                        {
                            offsetList.Add(index - 1);
                            break;
                        }
                        if (arr[indx] == arrCmp1[indx])
                        {
                            indx++;
                        }
                        else
                            break;
                    } // Inner while
                } // Outer while
            }// Foreach
            return offsetList;
        }

        /* 
         * Searchs for table keys in form of PUSH or MOV EAX-EDI. 
         */
        public List<int> FindTBLKey_Pattern1(byte[] buf, String value)
        {
            var curOp = (byte)Opcodes.PUSH;
            var offsetList = new List<int>();
        search_again:
            var ui32 = Convert.ToUInt32(value, 16);
            var val = BitConverter.GetBytes(ui32);
            var arrCmp1 = new[] { curOp, val[0], val[1], val[2], val[3] };
            var index = 0;
            while (true)
            {
                var arr = new byte[arrCmp1.Length];

                /* Check EOF */
                if (buf.Length - index <= arrCmp1.Length)
                {
                    /* Check if we've found something.
                     * If we don't, we need to check for other registers (as the compiler could
                     * assign another register for the operation. */
                    if (curOp == (byte)Opcodes.PUSH)
                    {
                        curOp = (byte)MovOpcodes.EAX;
                        goto search_again;
                    }
                    else if (curOp != (byte)MovOpcodes.EDI)
                    {
                        curOp++;
                        goto search_again;
                    }
                    return offsetList;
                }

                Array.Copy(buf, index++, arr, 0, arrCmp1.Length);
                var indx = 0;
                while (true)
                {
                    if (indx == arrCmp1.Length)
                    {
                        offsetList.Add(index - 1);
                        break;
                    }
                    if (arr[indx] == arrCmp1[indx])
                    {
                        indx++;
                    }
                    else
                        break;
                }
            }     
        }

        public List<int> FindPrivateKey(byte[] buf, String value)
        {
            List<int> offsetList = new List<int>();
            UInt64 ui64 = Convert.ToUInt64(value, 16);
            byte[] val = BitConverter.GetBytes(ui64);
            var arrCmp1 = new[] { (byte)Opcodes.PUSH, val[4], val[5], val[6], val[7] };
            int index = 0;
            while (true)
            {
                var arr = new byte[arrCmp1.Length];

                /* Check EOF */
                if (buf.Length - index <= arrCmp1.Length)
                    return offsetList;

                Array.Copy(buf, index++, arr, 0, arrCmp1.Length);
                var indx = 0;
                while (true)
                {
                    if (indx == arrCmp1.Length)
                    {
                        offsetList.Add(index - 1);
                        break;
                    }
                    if (arr[indx] == arrCmp1[indx])
                    {
                        indx++;
                    }
                    else
                        break;
                }

            }
        }

        #endregion

        #region Read value from offset

        public int ReadVersion_Original(byte[] buf, long offset)
        {
           var bufx = new byte[6];
           Array.Copy(buf, offset, bufx, 0, 6) ;
           return BitConverter.ToInt32(bufx, bufx[0] == (byte)CompareOpcodes.IWORDDWORDEAX ? 1 : 2);
        }

        public int ReadVersion_Display(byte[] buf, long offset)
        {
            var bufx = new byte[5];
            Array.Copy(buf, offset, bufx, 0, 5);
            return BitConverter.ToInt32(bufx, 1);
        }

        public UInt64 ReadPrivateKey(byte[] buf,long offset)
        {
            var bufx = new byte[10];
            Array.Copy(buf, offset, bufx, 0, 10);
            var splitted = new byte[8];
            Array.Copy(bufx, 6, splitted, 0, 4);
            Array.Copy(bufx, 1, splitted, 4, 4);
            return BitConverter.ToUInt64(splitted, 0);
        }

        public UInt32 ReadPort(byte[] buf, long offset)
        {
            var bufx = new byte[5];
            Array.Copy(buf, offset +1, bufx, 0, 4);
            return BitConverter.ToUInt32(bufx,0);
        }

        public int ReadTBLKey_Pattern1(byte[] buf, long offset)
        {
            var bufx = new byte[5];
            Array.Copy(buf, offset, bufx, 0, 5);
            return BitConverter.ToInt32(bufx, 1);
        }


        public int ReadTBLKey_Pattern3(byte[] buf, long offset)
        {
            // 000000 00000000
            var bufx = new byte[8];
            List<int> list = new List<int>();
            Array.Copy(buf, offset, bufx, 0, 8);
            return BitConverter.ToInt32(bufx, 3);
        }

        public string ReadURL(byte[] buf, long offset)
        {
            string found_url = string.Empty;
            var bufx = new byte[httpsPattern.Length];


            Array.Copy(buf, offset, bufx, 0, httpsPattern.Length);
            if (CompareArray(bufx, 0, HttpPattern, 0, HttpPattern.Length) || CompareArray(bufx, 0, httpsPattern, 0, httpsPattern.Length))
            {
                List<byte> str = new List<byte>();
                byte b = 0xFF;
                int index = 0;
                do
                {
                    str.Add(b=buf[offset + index++]);
                } while (b != 0x00);
                found_url = Encoding.ASCII.GetString(str.ToArray());

            }
            return found_url;
        }

        public bool checkMulticlientEnabled(byte[] buf, long offset)
        {
            byte val = buf[offset];
            return val != (byte)JmpShort.JNE;
        }

        #endregion

        #region Write value to offset

        private void ApplyPatch(byte[] buf, byte[] patch, long offset)
        {
            using (var ms = new MemoryStream(buf))
            {
                using (var bw = new BinaryWriter(ms))
                {
                    bw.Seek((int)offset, SeekOrigin.Begin);
                    bw.Write(patch, 0, patch.Length);
                }
            }
        }

        public void WriteNewKey_Pattern3(byte[] buf, long offset, uint key)
        {
            byte[] val = BitConverter.GetBytes(key);

            byte opcode = buf[offset];
            if (opcode != (byte)Opcodes.LEA)
            {
                throw new InvalidDataException("OPcode at the offset is not valid.");
            }
            byte[] patch = new[] {buf[offset], buf[offset + 1], buf[offset + 2], val[0], val[1], val[2], val[3]};
            ApplyPatch(buf, patch, offset);
        }

        public void WriteNewKey_Pattern1(byte[] buf, long offset, uint key)
        {
            byte[] val = BitConverter.GetBytes(key);

            byte opcode = buf[offset];

            switch (opcode)
            {
                /* Valid pattern 1 opcodes */
                case (byte)Opcodes.PUSH:
                case (byte)MovOpcodes.EAX:
                case (byte)MovOpcodes.EBP:
                case (byte)MovOpcodes.EBX:
                case (byte)MovOpcodes.ECX:
                case (byte)MovOpcodes.EDI:
                case (byte)MovOpcodes.EDX:
                case (byte)MovOpcodes.ESI:
                case (byte)MovOpcodes.ESP:
                    break;
                default:
                    throw new InvalidDataException("OPcode at the offset is not valid.");
            }

            byte[] patch = new byte[] {opcode, val[0], val[1], val[2], val[3]};
            ApplyPatch(buf, patch, offset);
      
        }


        public void WriteNewPort(byte[] buf, long offset, ushort port)
        {
            byte[] val = BitConverter.GetBytes((uint)port);
            byte[] arr1 = { (byte)Opcodes.PUSH, val[0], val[1], val[2],val[3] };
            ApplyPatch(buf, arr1, offset);
        }

        public void WriteNewPrivateKey(byte[] buf, long offset, UInt64 newKey)
        {
            byte[] val = BitConverter.GetBytes(newKey);
            byte[] arr1 = { (byte)Opcodes.PUSH, val[4], val[5], val[6], val[7] };
            byte[] arr2 = { (byte)Opcodes.PUSH, val[0], val[1], val[2], val[3] };

            using (var ms = new MemoryStream(buf))
            {
                using (var bw = new BinaryWriter(ms))
                {
                    bw.Seek((int)offset, SeekOrigin.Begin);
                    bw.Write(arr1, 0, 5);
                    bw.Write(arr2, 0, 5);
                }
            }
        }

        public void WriteNewURL(byte[] buf, long offset, string value,long padding)
        {
            byte[] str_buf = Encoding.ASCII.GetBytes(value);
            byte[] pad = new byte[padding];
            using (var ms = new MemoryStream(buf))
            {
                using (var bw = new BinaryWriter(ms))
                {
                    bw.Seek((int) offset, SeekOrigin.Begin);
                    bw.Write(str_buf, 0, str_buf.Length);
                    bw.Write(pad, 0, pad.Length);
                }
            }
        }

        #endregion

        
    }
}
