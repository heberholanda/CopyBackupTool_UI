using CopyBackupToolUI_NS;
using System;
using System.Windows.Forms;

namespace CopyBackupToolUI.Models
{
    public class ConsoleLog
    {
        TextBox myConsoleTextBox;
        public ConsoleLog(TextBox myConsoleTextBox)
        {
            this.myConsoleTextBox = myConsoleTextBox;
        }
        public void AddConsoleLog(string message)
        {
            var _dateTimeNow = DateTime.Now.ToString("H:mm:ss - dd/MM/yyyy  ");
            this.myConsoleTextBox.AppendText(_dateTimeNow + message + Environment.NewLine);
            this.myConsoleTextBox.SelectionStart = this.myConsoleTextBox.Text.Length;
            this.myConsoleTextBox.ScrollToCaret();
            this.myConsoleTextBox.Refresh();
        }
        public string[] GetConsoleLog()
        {
            string[] _results = this.myConsoleTextBox.Text.Split('\n');
            return _results;
        }
        public string SaveConsoleLog()
        {
            try
            {
                var _dateTimeNow = DateTime.Now.ToString("dd-MM-yyyy");
                var _path = AppDomain.CurrentDomain.BaseDirectory + "Log";
                var _fileName = "ConsoleLog " + _dateTimeNow + ".txt";
                var _pathSave = (_path + "\\"+ _fileName);

                if (!HelpersStatic.FolderExists(_path))
                    HelpersStatic.FolderCreate(_path);

                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(_pathSave, true))
                {
                    foreach (var _line in GetConsoleLog())
                    {
                        var _newLine = HelpersStatic.ClearCharacters(_line);
                        file.WriteLine(_newLine);
                    }
                    return _fileName;
                }
            }
            catch (Exception ex)
            {
                var _ex = ex;
                return ex.ToString();
            }
        }
        public void ClearConsoleLog()
        {
            this.myConsoleTextBox.Text = "";
        }
    }
}
