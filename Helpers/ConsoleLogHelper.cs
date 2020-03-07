using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace CopyBackupToolUI.Helpers
{
    public static class ConsoleLogHelper
    {
        public static List<string> novoConsoleLog = new List<string>();

        delegate void AddCallback(string msg);
        public static void Add(string message)
        {
            if (Painel.consoleTextBox.InvokeRequired)
            {
                AddCallback callback = Add;
                Painel.consoleTextBox.InvokeIfRequired(s => { s.Text = message; });
            }
            else
            {
                var _dateTimeNow = DateTime.Now.ToString("H:mm:ss - dd/MM/yyyy  ");
                var _newMessage = _dateTimeNow + message + Environment.NewLine;
                novoConsoleLog.Add(_newMessage);
                Painel.consoleTextBox.AppendText(_newMessage);
            }
        }
        public static string Save()
        {
            try
            {
                var _dateTimeNow = DateTime.Now.ToString("dd-MM-yyyy");
                var _path = Path.Combine(ConfigFileHelper.ConfigPath, "Log");
                var _fileName = "ConsoleLog " + _dateTimeNow + ".txt";
                var _pathSave = (_path + "\\" + _fileName);

                if (!GlobalHelpers.FolderExists(_path))
                    GlobalHelpers.FolderCreate(_path);

                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(_pathSave, true))
                {
                    foreach (var _line in Get())
                    {
                        var _newLine = GlobalHelpers.ClearCharacters(_line);
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
        public static string[] Get()
        {
            return novoConsoleLog.ToArray();
        }
        public static void Clear()
        {
            novoConsoleLog.Clear();
            Painel.consoleTextBox.Text = "";
        }

        public static void InvokeIfRequired<T>(this T control, Action<T> action) where T : ISynchronizeInvoke
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => action(control)), null);
            }
            else
            {
                action(control);
            }
        }
    }
}
