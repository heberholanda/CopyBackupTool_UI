using CopyBackupToolUI.Helpers;
using CopyBackupToolUI.Models;
using System;
using System.Windows.Forms;

namespace CopyBackupToolUI.Forms
{
    public partial class Schedules : Form
    {
        public Schedules()
        {
            InitializeComponent();
            this.dataGridViewSchedulesConfigs.DataSource = ConfigFileHelper.JsonFileConfigs;
        }

        private void Schedules_Load(object sender, System.EventArgs e)
        {
        }

        private void dataGridViewSchedulesConfigs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 4:
                        redirectToUpdateForm(e.RowIndex);
                        break;
                    case 5:
                        //deleteData(e.RowIndex);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void redirectToUpdateForm(int row)
        {
            FileModel _fileConfig = new FileModel();

            _fileConfig.Title = dataGridViewSchedulesConfigs.Rows[row].Cells[0].Value.ToString();
            _fileConfig.Status = Convert.ToBoolean(dataGridViewSchedulesConfigs.Rows[row].Cells[1].Value);

            /*
            _fileConfig.CopyAndPaste.Status = ConfigFileHelper.JsonFileConfigs[row].CopyAndPaste.Status;
            _fileConfig.CopyAndPaste.Overwrite = ConfigFileHelper.JsonFileConfigs[row].CopyAndPaste.Overwrite;
            _fileConfig.CopyAndPaste.SourcePath = ConfigFileHelper.JsonFileConfigs[row].CopyAndPaste.SourcePath;
            _fileConfig.CopyAndPaste.DestinationPath = ConfigFileHelper.JsonFileConfigs[row].CopyAndPaste.DestinationPath;
            _fileConfig.CopyAndPaste.Ignore.Files = ConfigFileHelper.JsonFileConfigs[row].CopyAndPaste.Ignore.Files;
            _fileConfig.CopyAndPaste.Ignore.Folders = ConfigFileHelper.JsonFileConfigs[row].CopyAndPaste.Ignore.Files;

            _fileConfig.CompressFolder.Status = ConfigFileHelper.JsonFileConfigs[row].CompressFolder.Status;
            _fileConfig.CompressFolder.ZipFileName = ConfigFileHelper.JsonFileConfigs[row].CompressFolder.ZipFileName;
            _fileConfig.CompressFolder.SourcePath = ConfigFileHelper.JsonFileConfigs[row].CompressFolder.SourcePath;
            _fileConfig.CompressFolder.MoveToPath = ConfigFileHelper.JsonFileConfigs[row].CompressFolder.MoveToPath;
            _fileConfig.CompressFolder.Ignore.Files = ConfigFileHelper.JsonFileConfigs[row].CompressFolder.Ignore.Files;
            _fileConfig.CompressFolder.Ignore.Folders = ConfigFileHelper.JsonFileConfigs[row].CompressFolder.Ignore.Folders;
            */
            Form schedules = new SchedulesAdd(_fileConfig);
            schedules.ShowDialog();
        }
    }
}
