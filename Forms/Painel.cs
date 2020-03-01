using CopyBackupToolUI.Helpers;
using CopyBackupToolUI.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CopyBackupToolUI
{
    public partial class Painel : Form
    {
        public bool Terminating = false;
        public static Operations run { get; set; }

        public Painel()
        {
            InitializeComponent();
            ConfigFileHelper.Load();
            run = new Operations();
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
                notifyIcon.Dispose();

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
            ProgressBarHelper.Reset();

            // Run Configs
            foreach (var config in ConfigFileHelper.JsonFileConfigs)
            {
                if (config.Status)
                {
                    var _msg = "\n[ " + config.Title + " ] Starting...";
                    NotifyMessageSend("CopyBackup Tool", _msg);
                    ConsoleLogHelper.Add(_msg);

                    run.CompressFolder(config.CompressFolder);
                    run.CopyAndPaste(config.CopyAndPaste);

                    var _msg2 = "[ " + config.Title + " ] Finished!\n";
                    ConsoleLogHelper.Add(_msg2);
                    NotifyMessageSend("CopyBackup Tool", _msg2);
                }
                else
                {
                    ConsoleLogHelper.Add("\n[ "+ config.Title + " ] Not enabled. Status: "+config.Status);
                }
            }
            ConsoleLogHelper.Add("\nMy work is done!");
            ConsoleLogHelper.Add("\nProgress: "+ ProgressBarHelper.Progress + "  ProgressMaxValue: "+ ProgressBarHelper.ProgressMaxValue);
        }
        private void Configs_Click(object sender, EventArgs e)
        {
            Console.Beep();
            ConsoleLogHelper.Add("[ Configs ]  Searching for configuration file...");
            ConsoleLogHelper.Add("[ Configs ]  Path: "+ ConfigFileHelper.ConfigFull);
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
            ConsoleLogHelper.Add("[ Console ]  Teste Console");
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Console.Beep();
            ConsoleLogHelper.Clear();
            ConsoleLogHelper.Add("[ Console ]  Clean Console Log!");
        }
        private void ConsoleSave_Click(object sender, EventArgs e)
        {
            Console.Beep();
            var _log = ConsoleLogHelper.Save();
            ConsoleLogHelper.Add("[ Log ]  Saved! " + _log);
        }
            // Progress Bar
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
            // NotifyHelper Icon
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
        //          Others          //
        protected void NotifyMessageSend(string tipTitle, string tipText, int time = 1)
        {
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = tipTitle;
            notifyIcon.BalloonTipText = tipText;
            notifyIcon.ShowBalloonTip(time);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;
            this.Close();
        }
    }
}
