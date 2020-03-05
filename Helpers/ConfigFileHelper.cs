using CopyBackupToolUI.Forms;
using CopyBackupToolUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CopyBackupToolUI.Helpers
{
    public static class ConfigFileHelper
    {
        public static string ConfigPath = AppDomain.CurrentDomain.BaseDirectory + ConfigFile;
        public static string ConfigFile = "ConfigurationFile.json";
        public static string ConfigFullPath = "C:\\CopyBackupTool\\CopyBackupTool\\" + ConfigFile;
        public static List<FileModel> JsonFileConfigs = new List<FileModel>();
        
        public static void Load(bool showLog = true)
        {
            JsonFileConfigs = ConfigFileHelper.LoadJson(showLog);
        }
        public static FileModel GetFileModel(int id)
        {
            var fileConfigs = JsonConvert.DeserializeObject<List<FileModel>>(
                File.ReadAllText(ConfigFileHelper.ConfigFullPath)
            );
            return fileConfigs.Where(x => x.Id == id).FirstOrDefault();
        }
        public static List<FileModel> LoadJson(bool showLog)
        {
            try
            {
                if (showLog) {
                    ConsoleLogHelper.Add("[ Config ] Loading...");
                    ConsoleLogHelper.Add("[ Config ] Path: " + ConfigFullPath);
                }

                string json = File.ReadAllText(ConfigFullPath);
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

        public static void SaveOrUpdateJson(FileModel model)
        {
            try
            {
                ConsoleLogHelper.Add("[ Config ] Saving...");
                string json = File.ReadAllText(ConfigFullPath);
                List<FileModel> jsonDeserialize = JsonConvert.DeserializeObject<List<FileModel>>(json);

                if (GetFileModel(model.Id) == null) {
                    // Save
                    jsonDeserialize.Add(model);
                } else {
                    // Update
                    jsonDeserialize[model.Id] = model;
                }
                string jsonSerialize = JsonConvert.SerializeObject(jsonDeserialize, Formatting.Indented);
                File.WriteAllText(ConfigFullPath, jsonSerialize);
                ConsoleLogHelper.Add("[ Config ] Saved Path: " + ConfigFullPath);
            }
            catch (Exception ex)
            {
                ConsoleLogHelper.Add("[ Config ] ERROR in Saving");
                ConsoleLogHelper.Add("[ Config ] Ex: "+ ex.Message);
                throw;
            }
        }
    }
}
