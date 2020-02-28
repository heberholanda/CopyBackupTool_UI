using System;
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

        }
        private void Schedules_Load(object sender, EventArgs e)
        {
            
        }
        private void textBoxCopyPaste_SourcePath_Click(object sender, EventArgs e)
        {
            this.textBoxCopyPaste_SourcePath.Text = GetFolderPath();
        }
    }
}
