using CopyBackupToolUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace CopyBackupToolUI.Helpers
{
    public static class ConfigFileHelper
    {
        public static string ConfigPath = AppDomain.CurrentDomain.BaseDirectory + ConfigFile;
        public static string ConfigFile = "ConfigurationFile.json";
        public static string ConfigFull = "C:\\CopyBackupTool\\CopyBackupTool\\" + ConfigFile;
        public static List<FileModel> JsonFileConfigs = new List<FileModel>();
        
        public static void Load()
        {
            JsonFileConfigs = ConfigFileHelper.LoadJson();
        }
        public static List<FileModel> LoadJson()
        {
            try
            {
                ConsoleLogHelper.Add("[ Config ] Loading...");
                ConsoleLogHelper.Add("[ Config ] Path: " + ConfigFull);
                StreamReader reader = new StreamReader(ConfigFull);
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<FileModel>>(json);
            }
            catch (FileNotFoundException ex)
            {
                ConsoleLogHelper.Add("[ Config ] The file Config File not found! File: " + ex.FileName);
                return new List<FileModel>();
            }
            catch (IOException e)
            {
                ConsoleLogHelper.Add("[ Copy&Paste ] The configuration not exist.");
                ConsoleLogHelper.Add("[ Copy&Paste ] " + e.Message);
                return new List<FileModel>();
            }
            catch (Exception ex)
            {
                ConsoleLogHelper.Add("[ Config ] " + ex.Message);
                throw;
            }
        }
    }
}
