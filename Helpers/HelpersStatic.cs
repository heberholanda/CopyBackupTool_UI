﻿using System;
using System.IO;

namespace CopyBackupToolUI_NS
{
    public static class HelpersStatic
    {
        public static bool FileExists(string valuePath)
        {
            return (File.Exists(valuePath) ? true : false);
        }
        public static bool FolderExists(string valuePath)
        {
            return (Directory.Exists(valuePath) ? true : false);
        }
        public static void FolderCreate(string valuePath)
        {
            Directory.CreateDirectory(valuePath);
        }
        public static string ClearCharacters(string text)
        {
            return text
                    .Replace(Environment.NewLine, "")
                    .Replace("\r\n", "")
                    .Replace("\r", "")
                    .Replace("\n", "")
                    .Replace("\\r", "")
                    .Replace("\\n", "");
        }
    }
}