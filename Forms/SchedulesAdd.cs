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
            var _status = Convert.ToBoolean(this.checkBoxStatus.Text);

            var _copyPasteStatus = Convert.ToBoolean(this.checkBoxCopyPasteStatus.Text);
            var _copyPasteOverwrite = Convert.ToBoolean(this.checkBoxCopyPasteOverwrite.Text);
            var _copyPasteSource = this.textBoxCopyPaste_SourcePath.Text;
            var _copyPasteDestination = this.textBoxCopyPasteDestinationPath.Text;
            string[] _copyPasteIgnoreFiles = this.textBoxCopyPasteIgnoreFiles.Text.Split(',').ToArray();
            string[] _copyPasteIgnoreFolders = this.textBoxCopyPasteIgnoreFolders.Text.Split(',').ToArray();

            var _compressStatus = Convert.ToBoolean(this.checkBoxCompressStatus.Text);
            var _compressTitle = this.textBoxCompressTitle.Text;
            var _compressSource = this.textBoxCompressSourcePath.Text;
            var _compressDestination = this.textBoxCompressDestinationPath.Text;
            string[] _compressIgnoreFiles = this.textBoxCompressIgnoreFiles.Text.Split(',').ToArray();
            string[] _compressIgnoreFolders = this.textBoxCompressIgnoreFolders.Text.Split(',').ToArray();
        }
        private void ConvertToStringList(string myString)
        {

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
