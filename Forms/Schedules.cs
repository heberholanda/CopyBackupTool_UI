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
            FileModel _myConfig = dataGridViewSchedulesConfigs.Rows[row].DataBoundItem as FileModel;

            FileModel _fileConfigModel = new FileModel
            {
                Title = _myConfig.Title,
                Status = _myConfig.Status,
                CopyAndPaste = new CopyAndPaste
                {
                    Status = _myConfig.CopyAndPaste.Status,
                    Overwrite = _myConfig.CopyAndPaste.Overwrite,
                    SourcePath = _myConfig.CopyAndPaste.SourcePath,
                    DestinationPath = _myConfig.CopyAndPaste.DestinationPath,
                    Ignore = new Ignore()
                    {
                        Files = _myConfig.CopyAndPaste.Ignore.Files,
                        Folders = _myConfig.CopyAndPaste.Ignore.Folders
                    }
                },
                CompressFolder = new CompressFolder
                {
                    Status = _myConfig.CompressFolder.Status,
                    ZipFileName = _myConfig.CompressFolder.ZipFileName,
                    SourcePath = _myConfig.CompressFolder.SourcePath,
                    MoveToPath = _myConfig.CompressFolder.MoveToPath,
                    Ignore = new Ignore()
                    {
                        Files = _myConfig.CompressFolder.Ignore.Files,
                        Folders = _myConfig.CompressFolder.Ignore.Folders
                    }
                }
            };

            Form schedules = new SchedulesAdd(_fileConfigModel);
            schedules.ShowDialog();
        }
    }
}
