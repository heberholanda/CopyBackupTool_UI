using CopyBackupToolUI.Forms;
using CopyBackupToolUI.Helpers;
using CopyBackupToolUI.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CopyBackupToolUI
{
    public partial class SchedulesAdd : Form
    {
        FileModel _config = new FileModel();
        public SchedulesAdd()
        {
            InitializeComponent();
        }
        public SchedulesAdd(FileModel config)
        {
            InitializeComponent();
            _config = config;
        }

        public string GetFolderPath()
        {
            var _resultMSG = "";
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                    _resultMSG = dialog.SelectedPath;
            }
            return _resultMSG;
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textBoxTitle.Text = string.Empty;
            this.checkBoxStatus.Checked = false;

            this.checkBoxCopyPasteStatus.Checked = false;
            this.checkBoxCopyPasteOverwrite.Checked = false;
            this.textBoxCopyPaste_SourcePath.Text = string.Empty;
            this.textBoxCopyPasteDestinationPath.Text = string.Empty;
            this.textBoxCopyPasteIgnoreFiles.Text = string.Empty;
            this.textBoxCopyPasteIgnoreFolders.Text = string.Empty;

            this.checkBoxCompressStatus.Checked = false;
            this.textBoxCompressTitle.Text = string.Empty;
            this.textBoxCompressSourcePath.Text = string.Empty;
            this.textBoxCompressDestinationPath.Text = string.Empty;
            this.textBoxCompressIgnoreFiles.Text = string.Empty;
            this.textBoxCompressIgnoreFolders.Text = string.Empty;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Console.Beep();

            // Get Data
            //var _id = (ConfigFileHelper.JsonFileConfigs.Any(x => x.Id == _config.Id)) ? _config.Id : Guid.NewGuid();
            var _id = _config.Id;
            var _title = this.textBoxTitle.Text;
            var _status = this.checkBoxStatus.Checked;

            var _copyPasteStatus = this.checkBoxCopyPasteStatus.Checked;
            var _copyPasteOverwrite = this.checkBoxCopyPasteOverwrite.Checked;
            var _copyPasteSource = this.textBoxCopyPaste_SourcePath.Text;
            var _copyPasteDestination = this.textBoxCopyPasteDestinationPath.Text;
            string[] _copyPasteIgnoreFiles = this.textBoxCopyPasteIgnoreFiles.Text.Split(',').ToArray();
            string[] _copyPasteIgnoreFolders = this.textBoxCopyPasteIgnoreFolders.Text.Split(',').ToArray();

            var _compressStatus = this.checkBoxCompressStatus.Checked;
            var _compressTitle = this.textBoxCompressTitle.Text;
            var _compressSource = this.textBoxCompressSourcePath.Text;
            var _compressDestination = this.textBoxCompressDestinationPath.Text;
            string[] _compressIgnoreFiles = this.textBoxCompressIgnoreFiles.Text.Split(',').ToArray();
            string[] _compressIgnoreFolders = this.textBoxCompressIgnoreFolders.Text.Split(',').ToArray();

            // Create Models
            FileModel _myFileModel = new FileModel
            {
                Id = _id,
                Title = _title.ToString(),
                Status = _status,
                CopyAndPaste = new CopyAndPaste
                {
                    Status = _copyPasteStatus,
                    Overwrite = _copyPasteOverwrite,
                    SourcePath = _copyPasteSource,
                    DestinationPath = _copyPasteDestination,
                    Ignore = new Ignore
                    {
                        Files = _copyPasteIgnoreFiles,
                        Folders = _copyPasteIgnoreFolders
                    }
                },
                CompressFolder = new CompressFolder
                {
                    Status = _compressStatus,
                    ZipFileName = _compressTitle,
                    SourcePath = _compressSource,
                    MoveToPath = _compressDestination,
                    Ignore = new Ignore
                    {
                        Files = _compressIgnoreFiles,
                        Folders = _compressIgnoreFolders
                    }
                }
            };
            ConfigFileHelper.SaveOrUpdateJson(_myFileModel);

            // Update View
            ConfigFileHelper.Load(false);
            Schedules.dataGridViewSchedulesConfigs.DataSource = ConfigFileHelper.JsonFileConfigs;
        }
        private void Schedules_Load(object sender, EventArgs e)
        {
            try
            {
                // Load by DataGrid
                this.textBoxTitle.Text = _config.Title;
                this.checkBoxStatus.Checked = _config.Status;
               
                this.checkBoxCopyPasteStatus.Checked = _config.CopyAndPaste.Status;
                this.checkBoxCopyPasteOverwrite.Checked = _config.CopyAndPaste.Overwrite;
                this.textBoxCopyPaste_SourcePath.Text = _config.CopyAndPaste.SourcePath;
                this.textBoxCopyPasteDestinationPath.Text = _config.CopyAndPaste.DestinationPath;
                this.textBoxCopyPasteIgnoreFiles.Text = GlobalHelpers.ConvertStringArrayToString(_config.CopyAndPaste.Ignore.Files);
                this.textBoxCopyPasteIgnoreFolders.Text = GlobalHelpers.ConvertStringArrayToString(_config.CopyAndPaste.Ignore.Folders);

                this.checkBoxCompressStatus.Checked = _config.CompressFolder.Status;
                this.textBoxCompressTitle.Text = _config.CompressFolder.ZipFileName;
                this.textBoxCompressSourcePath.Text = _config.CompressFolder.SourcePath;
                this.textBoxCompressDestinationPath.Text = _config.CompressFolder.MoveToPath;
                this.textBoxCompressIgnoreFiles.Text = GlobalHelpers.ConvertStringArrayToString(_config.CompressFolder.Ignore.Files);
                this.textBoxCompressIgnoreFolders.Text = GlobalHelpers.ConvertStringArrayToString(_config.CompressFolder.Ignore.Folders);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void textBoxCopyPaste_SourcePath_Click(object sender, EventArgs e){   this.textBoxCopyPaste_SourcePath.Text = GetFolderPath();    }
        private void textBoxCopyPaste_DestinationPath_Click(object sender, EventArgs e){   this.textBoxCopyPasteDestinationPath.Text = GetFolderPath();    }
        private void textBoxCompressSourcePath_Click(object sender, EventArgs e){    this.textBoxCompressSourcePath.Text = GetFolderPath();  }
        private void textBoxCompressDestinationPath_Click(object sender, EventArgs e){  this.textBoxCompressDestinationPath.Text = GetFolderPath(); }
    }
}
