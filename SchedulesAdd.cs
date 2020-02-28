using System;
using System.IO;
using System.Windows.Forms;

namespace CopyBackupToolUI
{
    public partial class SchedulesAdd : Form
    {
        public SchedulesAdd()
        {
            InitializeComponent();
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
        private void textBox_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.textBoxCopyPasteSourcePath.Text = dialog.SelectedPath;
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCopyPasteSourcePath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
