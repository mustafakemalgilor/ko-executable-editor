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
using System.Security.Cryptography;

namespace KOExecutableEditor
{
    [Serializable]
    public class FileInformation
    {
        public string OriginalName;
        public string MD5Hash;
        public long Size;
    }

    [Serializable]
    public class AuthorInformation
    {
        public String Name;
        public String Definition;
        public String URL;
        public DateTime Timestamp = DateTime.Now;
    }
    [Serializable]
    public class URLInformation
    {
        public long Offset;
        public long Length;
    }

    [Serializable]
    public class FileSignature
    {

        public long ELfaNew { get; set; }
        public long SizeOfCode { get; set; }
        public long SizeOfUninitializedData { get; set; }
        public long AddressOfEntryPoint { get; set; }
        public long BaseOfData { get; set; }
        public long SizeOfImage { get; set; }

        public void Initialize(PeHeaderReader pr)
        {
            ELfaNew = pr.DosHeader.e_lfanew;
            if (pr.Is32BitHeader)
            {
                SizeOfCode = pr.OptionalHeader32.SizeOfCode;
                SizeOfUninitializedData = pr.OptionalHeader32.SizeOfUninitializedData;
                AddressOfEntryPoint = pr.OptionalHeader32.AddressOfEntryPoint;
                BaseOfData = pr.OptionalHeader32.BaseOfData;
                SizeOfImage = pr.OptionalHeader32.SizeOfImage;
            }
            else
            {
                SizeOfCode = pr.OptionalHeader64.SizeOfCode;
                SizeOfUninitializedData = pr.OptionalHeader64.SizeOfUninitializedData;
                AddressOfEntryPoint = pr.OptionalHeader64.AddressOfEntryPoint;
                BaseOfData = 0;
                SizeOfImage = pr.OptionalHeader64.SizeOfImage;
            }
        }

        public bool Compare(FileSignature other)
        {
            return 
                (
                (ELfaNew == other.ELfaNew &&
                SizeOfCode == other.SizeOfCode &&
                SizeOfUninitializedData == other.SizeOfUninitializedData &&
                AddressOfEntryPoint == other.AddressOfEntryPoint &&
                BaseOfData == other.BaseOfData &&
                SizeOfImage == other.SizeOfImage)
                );
        }
    }

    [Serializable]
    public class Executable
    {
        public FileInformation FileInformation;
        public AuthorInformation AuthorInformation;
        public FileSignature FileSignature;
        public List<int> PrivateKeyOffsetList = new List<int>();
        public List<int> GameserverPortOffsetList = new List<int>();
        public List<int> LoginserverPortOffsetList = new List<int>();

        public List<int> TableKeysPattern1Key1 = new List<int>();
        public List<int> TableKeysPattern1Key2 = new List<int>();
        public List<int> TableKeysPattern1Key3 = new List<int>();

        public List<int> TableKeysPattern3Key1 = new List<int>();
        public List<int> TableKeysPattern3Key2 = new List<int>();
        public List<int> TableKeysPattern3Key3 = new List<int>();
        // offset - length
        public List<URLInformation> URLOffsetList = new List<URLInformation>();

        public int VersionOriginal;
        public int VersionDisplay;

        public int MutexOffset;
        public int LauncherOffset;
        public int MovePacketIntervalOffset;
        public int RotatePacketIntervalOffset;
        public int OpenWebsiteOffset;

        public bool Initialize
        (
            FileInfo fii, 
            AuthorInformation ai,
            List<int> pk, 
            List<int> gs, 
            List<int> ls, 
            List<int> tk1K1,
            List<int> tk1K2,
            List<int> tk1K3,

            List<int> tk3K1,
            List<int> tk3K2,
            List<int> tk3K3,
            Dictionary<int,int> urlOffset, 
            int verOr,
            int verDp,
            int mutexOff,
            int launcherOff,
            int moveOff,
            int rotateOff,
            int openWebsiteoff
        )
        {
            if (ai == null)
                return false;
            AuthorInformation = ai;
            FileSignature = new FileSignature();
            FileSignature.Initialize(new PeHeaderReader(fii.FullName));
            FileInformation = new FileInformation { OriginalName = fii.Name, Size = fii.Length };
            byte[] hash;
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(fii.FullName))
                {
                    hash = md5.ComputeHash(stream);
                }
            }
            FileInformation.MD5Hash = BitConverter.ToString(hash);

            foreach (var v in pk)
                PrivateKeyOffsetList.Add(v);
            foreach (var v in gs)
                GameserverPortOffsetList.Add(v);
            foreach (var v in ls)
                LoginserverPortOffsetList.Add(v);

            foreach(var v in tk1K1)
                TableKeysPattern1Key1.Add(v);
            foreach (var v in tk1K2)
                TableKeysPattern1Key2.Add(v);
            foreach (var v in tk1K3)
                TableKeysPattern1Key3.Add(v);



            foreach (var v in tk3K1)
                TableKeysPattern3Key1.Add(v);
            foreach (var v in tk3K2)
                TableKeysPattern3Key2.Add(v);
            foreach (var v in tk3K3)
                TableKeysPattern3Key3.Add(v);

            foreach (var v in urlOffset)

                URLOffsetList.Add(new URLInformation {Offset = v.Key, Length = v.Value});

            VersionOriginal = verOr;
            VersionDisplay = verDp;

            MutexOffset = mutexOff;
            LauncherOffset = launcherOff;
            MovePacketIntervalOffset = moveOff;
            RotatePacketIntervalOffset = rotateOff;
            OpenWebsiteOffset = openWebsiteoff;

            return true;
        }

        public bool IsSameSignatureWith(FileSignature fs)
        {
            return fs.Compare(fs);
        }
    }
}
