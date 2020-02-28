using CopyBackupToolUI.Models;
using CopyBackupToolUI_NS;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CopyBackupToolUI
{
    public partial class Painel : Form
    {
        public bool Terminating = false;
        public static Operations run { get; set; }
        public static Painel MyForm;
        public ConsoleLog Mylog;

        public Painel()
        {
            InitializeComponent();
            Mylog = new ConsoleLog(consoleTextBox);
            run = new Operations(Mylog);
            MyForm = this;
        }

        //          Custon          //
        private void Form_Load(object sender, EventArgs e)
        {
            Console.Beep();
        }
        private void Form_Load_Tray(object sender, EventArgs e)
        {
            this.trayMenuContextStrip.Items.Clear();
            this.trayMenuContextStrip.Items.Add("&Restore");
            this.trayMenuContextStrip.Items.Add("-");
            this.trayMenuContextStrip.Items.Add("E&xit");
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Terminating)
            {
                // the idle state has occurred, and the tray notification should be gone.
                // ok to shutdown now
                return;
            }

            if (e.CloseReason == CloseReason.UserClosing && MessageBox.Show("Do you really want to close the program?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                // only the user, selecting Cancel in a MessageBox, can do this.
                e.Cancel = true;
            }
            if (!e.Cancel)
            {
                // The application will shut down.

                // We cancel the shutdown, because the timer will do the shutdown when it fires.
                // This will return to the app and allow the idle state to occur.
                e.Cancel = true;

                // Dispose of the tray icon this way.
                this.notifyIcon.Dispose();

                // Set the termination flag so that the next entry into this event will
                // not be cancelled.
                Terminating = true;

                // Activate the timer to fire
                this.timer.Interval = 100;
                this.timer.Enabled = true;
                this.timer.Start();
            }
        }
            // Buttons
        private void Run_Click(object sender = null, EventArgs e = null)
        {
            Console.Beep();

            // ProgressBar
            ProgressBarReset();
            run.Progress = 0;
            run.ProgressMaxValue = 1;

            foreach (var config in run.JsonFileConfigs)
            {
                if (config.Status)
                {
                    var _msg = "\n[ " + config.Title + " ] Starting...";
                    ShowNotifyMsg("CopyBackup Tool", _msg);
                    Mylog.AddConsoleLog(_msg);

                    run.CompressFolder(config.CompressFolder);
                    run.CopyAndPaste(config.CopyAndPaste);

                    var _msg2 = "[ " + config.Title + " ] Finished!\n";
                    Mylog.AddConsoleLog(_msg2);
                    ShowNotifyMsg("CopyBackup Tool", _msg2);
                }
                else
                {
                    Mylog.AddConsoleLog("\n[ "+ config.Title + " ] Not enabled. Status: "+config.Status);
                }
            }
            Mylog.AddConsoleLog("\nMy work is done!");
        }
        private void Configs_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Mylog.AddConsoleLog("[ Configs ]  Searching for configuration file...");
            Mylog.AddConsoleLog("[ Configs ]  Found this: "+ AppDomain.CurrentDomain.BaseDirectory + "\\" + run.ConfigFile);
        }
        private void Schedules_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Form schedulesForm = new SchedulesAdd();
            schedulesForm.ShowDialog();
        }
        private void Console_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Mylog.AddConsoleLog("[ Console ]  Teste Console");
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Mylog.ClearConsoleLog();
            Mylog.AddConsoleLog("[ Console ]  Clean Console Log!");
        }
        private void ConsoleSave_Click(object sender, EventArgs e)
        {
            Console.Beep();
            var _log = Mylog.SaveConsoleLog();
            Mylog.AddConsoleLog("[ Log ]  Saved! " + _log);
        }
        public static void ProgressBarUpdate(int value)
        {
            var _maxValue = (run.ProgressMaxValue == 1) ? 100: run.ProgressMaxValue;
            var _calc = ( (double)value / (double)_maxValue);
            int _newValue = (int)(_calc * 100);
            progressBar.Value = value;
            progressBarPercentLabel.Text = value + "%";
        }
        public static void ProgressBarReset()
        {
            progressBar.Value = 0;
            progressBarPercentLabel.Text = 0 + "%";
            run.ProgressMaxValue = 0;
        }
        // Views
        private void Tray_Options_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var caseSwitch = e.ClickedItem.Text;
            switch (caseSwitch)
            {
                case "&Restore":
                    Show();
                    return;
                case "E&xit":
                    this.Close();
                    break;
                default:
                    break;
            }
        }
            // Notify Icon
        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            var _forms = Application.OpenForms;
            foreach (Form _form in _forms) {
                if (_form.Visible)
                {
                    Hide();
                }
                else
                {
                    Show();
                    WindowState = FormWindowState.Normal;
                }
                break;
            }
        }
        public void SendConsoleMsg(string msg, string title = "", bool status = false)
        {
            var _dateTimeNow = DateTime.Now.ToString("dd/MM/yyyy H:mm:ss");
            this.consoleTextBox.Text = string.Concat(this.consoleTextBox.Text, _dateTimeNow + ( (title.Length > 0) ?  " [ " + title + " ]  " : " ") + msg + Environment.NewLine);
        }

        //          Others          //
        protected void ShowNotifyMsg(string tipTitle, string tipText, int time = 1)
        {
            try
            {
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipTitle = tipTitle;
                notifyIcon.BalloonTipText = tipText;
                notifyIcon.ShowBalloonTip(time);
            }
            catch (Exception ex)
            {
            }
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;
            this.Close();
        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

    }
}
