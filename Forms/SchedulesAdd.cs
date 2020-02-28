using CopyBackupToolUI_NS;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CopyBackupToolUI
{
    public partial class SchedulesAdd : Form
    {
        public SchedulesAdd()
        {
            InitializeComponent();
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

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Console.Beep();

            // Get Data
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
            Ignore _myCopyIgnoreCopy = new Ignore();
                _myCopyIgnoreCopy.Files = _copyPasteIgnoreFiles;
                _myCopyIgnoreCopy.Folders = _copyPasteIgnoreFolders;
        
            Ignore _myCopyIgnoreCompress = new Ignore();
                _myCopyIgnoreCompress.Files = _compressIgnoreFiles;
                _myCopyIgnoreCompress.Folders = _compressIgnoreFolders;

            CopyAndPaste _myCopy = new CopyAndPaste();
                _myCopy.Status = _copyPasteStatus;
                _myCopy.Overwrite = _copyPasteOverwrite;
                _myCopy.SourcePath = _copyPasteSource;
                _myCopy.DestinationPath = _copyPasteDestination;
                _myCopy.Ignore = _myCopyIgnoreCopy;

            CompressFolder _myCompress = new CompressFolder();
                _myCompress.Status = _compressStatus;
                _myCompress.ZipFileName = _compressTitle;
                _myCompress.SourcePath = _compressSource;
                _myCompress.MoveToPath = _compressDestination;

            FileModel _myFileModel = new FileModel();
                _myFileModel.Title = _title.ToString();
                _myFileModel.Status = _status;
                _myFileModel.CopyAndPaste = _myCopy;
                _myFileModel.CompressFolder = _myCompress;


        }
        private void Schedules_Load(object sender, EventArgs e)
        {
            
        }
        private void textBoxCopyPaste_SourcePath_Click(object sender, EventArgs e){   this.textBoxCopyPaste_SourcePath.Text = GetFolderPath();    }
        private void textBoxCopyPaste_DestinationPath_Click(object sender, EventArgs e){   this.textBoxCopyPasteDestinationPath.Text = GetFolderPath();    }
        private void textBoxCompressSourcePath_Click(object sender, EventArgs e){    this.textBoxCompressSourcePath.Text = GetFolderPath();  }
        private void textBoxCompressDestinationPath_Click(object sender, EventArgs e){  this.textBoxCompressDestinationPath.Text = GetFolderPath(); }
    }
}
