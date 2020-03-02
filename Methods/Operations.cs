using CopyBackupToolUI.Helpers;
using CopyBackupToolUI.Models;
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
        public int Progress { get; set; }
        public int ProgressMaxValue { get; set; }
        public void CompressFolder(CompressFolder compress)
        {
            if (compress.Status != true) {
                ConsoleLogHelper.Add("[ {CompressFolder} ]   Not enabled. Stoped!  Status: " + compress.Status);
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
                    //this.Progress++;
                    //Painel.ProgressBarUpdate(this.Progress);
                    //ProgressBarHelper.DataGridViewTextBoxColumn_Update();

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
                        ConsoleLogHelper.Add("[ ZipFile ]   '"+ _folder + "' folder successfully added.");
                    }

                    // Add Files
                    var _filesIgnore = new HashSet<string>(compress.Ignore.Files);
                    var _filesAll = Directory.GetFiles(compress.SourcePath, "*", SearchOption.AllDirectories).ToList();
                    var _filesWithoutIgnore = _filesAll.Where(p => !_filesIgnore.Contains(p.Replace(compress.SourcePath + "\\", ""))).ToList();
                    foreach (var _file in _filesWithoutIgnore)
                    {
                        zip.AddFile(_file, Path.GetDirectoryName(_file).Replace(compress.SourcePath, string.Empty));
                        ConsoleLogHelper.Add("[ ZipFile ]   '"+ _file + "' file successfully added.");
                    }

                    zip.Comment = "Created: " + _dateNow;
                    zip.Save(compress.MoveToPath + "\\" + compress.ZipFileName + " - " + _dateNow + ".zip");
                    ConsoleLogHelper.Add("[ ZipFile ]   '"+ compress.ZipFileName + ".zip' successfully created." + Environment.NewLine);
                }
            }
            catch (ZipException ex) {
                ConsoleLogHelper.Add("[ ZipFile ]   " + ex.Message);
            }
            catch (FileNotFoundException ex) {
                ConsoleLogHelper.Add("[ ZipFile ]   " + ex.Message);
            }
            catch (DirectoryNotFoundException ex) {
                System.Text.RegularExpressions.Regex pathMatcher = new System.Text.RegularExpressions.Regex(@"[^']+");
                ConsoleLogHelper.Add("[ ZipFile ]   Could not find a part of the path: " + pathMatcher.Matches(ex.Message)[1].Value);
            }
            catch (ArgumentException ex) {
                ConsoleLogHelper.Add("[ ZipFile ]   " + ex.Message);
            }
            catch (Exception ex) {
                ConsoleLogHelper.Add("[ ZipFile ]   " + ex.Message);
                throw;
            }
        }
        public void CopyAndPaste(CopyAndPaste copy)
        {
            if (copy.Status == false) {
                ConsoleLogHelper.Add("[ Copy&Paste ]   The SourcePath (" + copy.SourcePath + ") is not enabled. Pass!");
                return;
            }
            if (string.IsNullOrEmpty(copy.SourcePath)) {
                ConsoleLogHelper.Add("[ Copy&Paste ]   The SourcePath ("+ copy.SourcePath + ") is emply. Stoped!");
                return;
            }
            if (string.IsNullOrEmpty(copy.DestinationPath)) {
                ConsoleLogHelper.Add("[ Copy&Paste ]   The DestinationPath ("+ copy.DestinationPath + ") is emply. Stoped!");
                return;
            }

            string[] directories = Directory.GetDirectories(copy.SourcePath, "*.*", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(copy.SourcePath, "*.*", SearchOption.AllDirectories);

            //this.ProgressMaxValue = (directories.Length + files.Length + 1);
            //Painel.progressBar.Maximum = this.ProgressMaxValue;

            var _max = (directories.Length + files.Length + 1);
            ProgressBarHelper.SetMaxValue(_max);

            // Folders
            try
            {
                _ = Parallel.ForEach(directories, currentPath =>
                {
                    //this.Progress++;
                    //Painel.ProgressBarUpdate(this.Progress);
                    ProgressBarHelper.Update();

                    string _folderNow = currentPath.Replace(copy.SourcePath + "\\", "");
                    var _folderIgnoreCheck = copy.Ignore.GetFolders().FirstOrDefault(x => x == _folderNow);
                    
                    if (string.IsNullOrEmpty(_folderIgnoreCheck))
                    {
                        Directory.CreateDirectory(currentPath.Replace(copy.SourcePath, copy.DestinationPath));
                        ConsoleLogHelper.Add("[ Copy&Paste ]   Create Directory: " + _folderNow);
                    }
                    else
                    {
                        ConsoleLogHelper.Add("[ Copy&Paste ]   Folder was ignored: "+ _folderNow);
                    }

                });
                ConsoleLogHelper.Add("[ Copy&Paste ]   Folder was successfully moved!" + Environment.NewLine);
            }
            catch (IOException)
            {
                ConsoleLogHelper.Add("[ Copy&Paste ]   The folder already exists.");
            }
            catch (ArgumentNullException ex)
            {
                ConsoleLogHelper.Add("[ Copy&Paste ]   " + ex.Message);
            }

            catch (ArgumentException ex)
            {
                ConsoleLogHelper.Add("[ Copy&Paste ]   " + ex.Message);
            }
            catch (AggregateException ex)
            {
                ConsoleLogHelper.Add("[ Copy&Paste ]   " + ex.Message);
            }
            catch (Exception ex)
            {
                ConsoleLogHelper.Add("[ Copy&Paste ]   " + ex.Message);
                throw;
            }

            // Files
            try
            {
                Parallel.ForEach(files, newPath =>
                {
                    //this.Progress++;
                    //Painel.ProgressBarUpdate(this.Progress);
                    ProgressBarHelper.Update();

                    var _fileNow = newPath.Replace(copy.SourcePath + "\\", "");
                    var _fileIgnoreCheck = copy.Ignore.GetFiles().FirstOrDefault(x => x == _fileNow);
                    if (String.IsNullOrEmpty(_fileIgnoreCheck))
                    {
                        try
                        {
                            File.Copy(newPath, newPath.Replace(copy.SourcePath, copy.DestinationPath), copy.Overwrite);
                            ConsoleLogHelper.Add("[ Copy&Paste ]   File: "+ _fileNow + "  Overwrite: "+ copy.Overwrite);
                        }
                        catch (IOException e)
                        {
                            if (e.HResult == -2147024816)
                            {
                                ConsoleLogHelper.Add("[ Copy&Paste ]   The file '"+ _fileNow + "' already exists.");
                            }
                        }
                    } else
                    {
                        ConsoleLogHelper.Add("[ Copy&Paste ]   The file '"+ _fileNow + "' was ignored.");
                    }

                });
            }
            catch (IOException e)
            {
                if (e.HResult == -2147024816)
                {
                    ConsoleLogHelper.Add("[ Copy&Paste ]   The file already exists.");
                }
            }
            catch (ArgumentNullException e)
            {
                ConsoleLogHelper.Add("[ Copy&Paste ]   " + e.Message);
            }
            catch (ArgumentException e)
            {
                ConsoleLogHelper.Add("[ Copy&Paste ]   " + e.Message);
            }
            catch (AggregateException ex)
            {
                ConsoleLogHelper.Add("[ Copy&Paste ]   " + ex.Message);
            }
            catch (Exception e)
            {
                ConsoleLogHelper.Add("[ Copy&Paste ]   " + e.Message);
                throw;
            }
        }
    }
}
