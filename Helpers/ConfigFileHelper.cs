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
        public static string ConfigPath = AppDomain.CurrentDomain.BaseDirectory;
        public static string ConfigFile = "ConfigurationFile.json";
        public static string ConfigFullPath = Path.Combine(ConfigPath, ConfigFile);
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
                    ConsoleLogHelper.Add("[ Config ] Load in path: " + ConfigFullPath);
                }

                string json = File.ReadAllText(ConfigFullPath);
                return JsonConvert.DeserializeObject<List<FileModel>>(json);
            }
            catch (FileNotFoundException ex)
            {
                ConsoleLogHelper.Add("[ Config ] The config file not found! File: " + ex.FileName);
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
        public static void SaveOrUpdate(FileModel model)
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
                ConsoleLogHelper.Add("[ Config ] Saved in path: " + ConfigFullPath);
            }
            catch (Exception ex)
            {
                ConsoleLogHelper.Add("[ Config ] ERROR in saving");
                ConsoleLogHelper.Add("[ Config ] Ex: "+ ex.Message);
                throw;
            }
        }
        public static void Delete(int configId)
        {
            ConsoleLogHelper.Add("[ Config ] Deleting...");
            string json = File.ReadAllText(ConfigFullPath);
            List<FileModel> jsonDeserialize = JsonConvert.DeserializeObject<List<FileModel>>(json);

            if (GetFileModel(configId) != null) {
                // Delete
                jsonDeserialize.RemoveAt(configId);
            }

            string jsonSerialize = JsonConvert.SerializeObject(jsonDeserialize, Formatting.Indented);
            File.WriteAllText(ConfigFullPath, jsonSerialize);
            ConsoleLogHelper.Add("[ Config ] Deleted in path: " + ConfigFullPath);
        }
    }
}
