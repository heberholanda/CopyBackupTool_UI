using CopyBackupToolUI.Models;
using CopyBackupToolUI_NS;
using Ionic.Zip;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyBackupToolUI
{
    public class Operations : IOperations<FileModel>
    {
        public ConsoleLog _log;
        public List<FileModel> JsonFileConfigs { get; set; }
        public string ConfigPath { get; set; }
        public string ConfigFile { get; set; }
        public int Progress { get; set; }
        public int ProgressMaxValue { get; set; }

        public Operations(ConsoleLog log)
        {
            //this.Progress = 1;
            //this.ProgressMaxValue = 1;
            this._log = log;
            this.ConfigFile = "ConfigurationFile.json";
            this.ConfigPath = AppDomain.CurrentDomain.BaseDirectory + ConfigFile;
            this.JsonFileConfigs = new List<FileModel>();
            this.JsonFileConfigs = this.LoadJson();
        }
        public int getProgressBar()
        {
            return this.ProgressMaxValue;
        }
        public List<FileModel> LoadJson()
        {
            //var jsonTest = HelpersStatic.JsonIsValid(this.ConfigPath);
            try
            {
                _log.AddConsoleLog("[ Config ] Loading...");
                _log.AddConsoleLog("[ Config ] Path: "+ this.ConfigPath);
                StreamReader reader = new StreamReader(this.ConfigPath);
                //bool _jsonIsValid = json.IsJsonValid<test>();
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<FileModel>>(json);
            }
            catch (FileNotFoundException ex)
            {
                _log.AddConsoleLog("[ Config ] The file Config File not found! File: "+ ex.FileName);
                return new List<FileModel>();
            }
            catch (Exception ex)
            {
                _log.AddConsoleLog("[ Config ] " + ex.Message);
                throw;
            }
        }
        public void CompressFolder(CompressFolder compress)
        {
            if (compress.Status != true) {
                _log.AddConsoleLog("[ {CompressFolder} ] Not enabled. Stoped! Status: " + compress.Status);
                return;
            }
            try
            {
                // https://archive.codeplex.com/?p=dotnetzip#Zip/ZipFile.cs
                // Encode Type Set
                EncodingProvider provider = CodePagesEncodingProvider.Instance;
                Encoding.RegisterProvider(provider);

                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    this.Progress++;
                    Form1.ProgressBarUpdate(this.Progress);

                    string _dateNow = DateTime.Now.ToString("dd-MM-yyyy HH-mm");
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;

                    // Add Folders
                    var _foldersIgnore = new HashSet<string>(compress.Ignore.Folders);
                    var _foldersAll = Directory.GetDirectories(compress.SourcePath, "*", SearchOption.AllDirectories).ToList();
                    var _foldersWithoutIgnore = _foldersAll.Where(p => !_foldersIgnore.Contains(p.Replace(compress.SourcePath + "\\", ""))).ToList();
                    foreach (var _folder in _foldersWithoutIgnore)
                    {
                        var _folderName = _folder.Replace(compress.SourcePath + "\\", "");
                        zip.AddDirectory(_folder, _folderName);
                        //zip.AddSelectedFiles("*", _folder, true);
                        //zip.AddFile(_folder, Path.GetDirectoryName(_folder).Replace(folder.SourcePath, string.Empty));
                        _log.AddConsoleLog("[ ZipFile ] {"+ _folder + "} folder successfully added.");
                    }

                    // Add Files
                    var _filesIgnore = new HashSet<string>(compress.Ignore.Files);
                    var _filesAll = Directory.GetFiles(compress.SourcePath, "*", SearchOption.AllDirectories).ToList();
                    var _filesWithoutIgnore = _filesAll.Where(p => !_filesIgnore.Contains(p.Replace(compress.SourcePath + "\\", ""))).ToList();
                    foreach (var _file in _filesWithoutIgnore)
                    {
                        zip.AddFile(_file, Path.GetDirectoryName(_file).Replace(compress.SourcePath, string.Empty));
                        _log.AddConsoleLog("[ ZipFile ] {"+ _file + "} file successfully added.");
                    }

                    zip.Comment = "Created: " + _dateNow;
                    zip.Save(compress.MoveToPath + "\\" + compress.ZipFileName + " - " + _dateNow + ".zip");
                    _log.AddConsoleLog("[ ZipFile ] {"+ compress.ZipFileName + "}.zip successfully created." + Environment.NewLine);
                }
            }
            catch (ZipException ex) {
                _log.AddConsoleLog("[ ZipFile ] " + ex.Message);
            }
            catch (FileNotFoundException ex) {
                _log.AddConsoleLog("[ ZipFile ] " + ex.Message);
            }
            catch (DirectoryNotFoundException ex) {
                System.Text.RegularExpressions.Regex pathMatcher = new System.Text.RegularExpressions.Regex(@"[^']+");
                _log.AddConsoleLog("[ ZipFile ] Could not find a part of the path: " + pathMatcher.Matches(ex.Message)[1].Value);
            }
            catch (ArgumentException ex) {
                _log.AddConsoleLog("[ ZipFile ] " + ex.Message);
            }
            catch (Exception ex) {
                _log.AddConsoleLog("[ ZipFile ] " + ex.Message);
                throw;
            }
        }
        public void CopyAndPaste(CopyAndPaste copy)
        {
            if (copy.Status == false) {
                _log.AddConsoleLog("[ Copy&Paste ] The SourcePath (" + copy.SourcePath + ") is not enabled. Pass!");
                return;
            }
            if (String.IsNullOrEmpty(copy.SourcePath)) {
                _log.AddConsoleLog("[ Copy&Paste ] The SourcePath ("+ copy.SourcePath + ") is emply. Stoped!");
                return;
            }
            if (String.IsNullOrEmpty(copy.DestinationPath)) {
                _log.AddConsoleLog("[ Copy&Paste ] The DestinationPath ("+ copy.DestinationPath + ") is emply. Stoped!");
                return;
            }

            string[] directories = Directory.GetDirectories(copy.SourcePath, "*.*", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(copy.SourcePath, "*.*", SearchOption.AllDirectories);
            this.ProgressMaxValue = (directories.Length + files.Length + 1);
            Form1.progressBar.Maximum = this.ProgressMaxValue;

            // Folders
            try
            {
                _ = Parallel.ForEach(directories, currentPath =>
                {
                    this.Progress++;
                    Form1.ProgressBarUpdate(this.Progress);

                    string _folderNow = currentPath.Replace(copy.SourcePath + "\\", "");
                    var _folderIgnoreCheck = copy.Ignore.GetFolders().FirstOrDefault(x => x == _folderNow);
                    
                    if (String.IsNullOrEmpty(_folderIgnoreCheck))
                    {
                        Directory.CreateDirectory(currentPath.Replace(copy.SourcePath, copy.DestinationPath));
                        _log.AddConsoleLog("[ Copy&Paste ] Create Directory: " + _folderNow);
                    }
                    else
                    {
                        _log.AddConsoleLog("[ Copy&Paste ] Folder was ignored: "+ _folderNow);
                    }

                });
                _log.AddConsoleLog("[ Copy&Paste ] Folder was successfully moved!" + Environment.NewLine);
            }
            catch (IOException)
            {
                _log.AddConsoleLog("[ Copy&Paste ] The folder already exists.");
            }
            catch (ArgumentNullException ex)
            {
                _log.AddConsoleLog("[ Copy&Paste ] " + ex.Message);
            }

            catch (ArgumentException ex)
            {
                _log.AddConsoleLog("[ Copy&Paste ] " + ex.Message);
            }
            catch (AggregateException ex)
            {
                _log.AddConsoleLog("[ Copy&Paste ] " + ex.Message);
            }
            catch (Exception ex)
            {
                _log.AddConsoleLog("[ Copy&Paste ] " + ex.Message);
                throw;
            }

            // Files
            try
            {
                Parallel.ForEach(files, newPath =>
                {
                    this.Progress++;
                    Form1.ProgressBarUpdate(this.Progress);

                    var _fileNow = newPath.Replace(copy.SourcePath + "\\", "");
                    var _fileIgnoreCheck = copy.Ignore.GetFiles().FirstOrDefault(x => x == _fileNow);
                    if (String.IsNullOrEmpty(_fileIgnoreCheck))
                    {
                        try
                        {
                            File.Copy(newPath, newPath.Replace(copy.SourcePath, copy.DestinationPath), copy.Overwrite);
                            _log.AddConsoleLog("[ Copy&Paste ] CopyFile: "+ _fileNow + "  Need replace? "+ copy.Overwrite);
                        }
                        catch (IOException e)
                        {
                            if (e.HResult == -2147024816)
                            {
                                _log.AddConsoleLog("[ Copy&Paste ] The file '"+ _fileNow + "' already exists.");
                            }
                        }
                    } else
                    {
                        _log.AddConsoleLog("[ Copy&Paste ] The file '"+ _fileNow + "' was ignored.");
                    }

                });
            }
            catch (IOException e)
            {
                if (e.HResult == -2147024816)
                {
                    _log.AddConsoleLog("[ Copy&Paste ] The file already exists.");
                }
            }
            catch (ArgumentNullException e)
            {
                _log.AddConsoleLog("[ Copy&Paste ] " + e.Message);
            }
            catch (ArgumentException e)
            {
                _log.AddConsoleLog("[ Copy&Paste ] " + e.Message);
            }
            catch (AggregateException ex)
            {
                _log.AddConsoleLog("[ Copy&Paste ] " + ex.Message);
            }
            catch (Exception e)
            {
                _log.AddConsoleLog("[ Copy&Paste ] " + e.Message);
                throw;
            }
        }
    }
}
