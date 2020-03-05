using System;
using System.IO;

namespace CopyBackupToolUI.Helpers
{
    public static class ProgressBarHelper
    {
        public static int Progress { get; set; }
        public static int ProgressMaxValue { get; set; }

        delegate int UpdateCallback();
        public static int UpdateBug()
        {
            try
            {
                var _progress = Progress++;
                //ProgressBarInvoke(_progress);
                ProgressBarLabelInvoke(_progress);

                return _progress;
            }
            catch (IOException)
            {
                return 0;
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
            catch (ArgumentException)
            {
                return 0;
            }
            catch (AggregateException)
            {
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        delegate void ProgressBarInvokeCallback(int value);
        private static void ProgressBarInvoke(int value)
        {
            if (Painel.progressBar.InvokeRequired) {
                ProgressBarInvokeCallback callback = ProgressBarInvoke;
                Painel.progressBar.InvokeIfRequired(s => { s.Value = value; });
            }
            else
                Painel.progressBar.Value = value;
        }

        delegate void ProgressBarLabelInvokeCallback(int value);
        private static void ProgressBarLabelInvoke(int value)
        {
            if (Painel.progressBarPercentLabel.InvokeRequired) {
                ProgressBarLabelInvokeCallback callback = ProgressBarLabelInvoke;
                Painel.progressBarPercentLabel.InvokeIfRequired(s => { s.Text = value + "%"; });
            }
            else
                Painel.progressBarPercentLabel.Text = value + "%";
        }

        public static int Update()
        {
            var _progress = Progress++;
            Painel.progressBar.Value = _progress;
            Painel.progressBarPercentLabel.Text = _progress + "%";
            return _progress;
        }
        public static int Update(int value)
        {
            var _maxValue = (ProgressMaxValue == 1) ? 100 : ProgressMaxValue;
            var _calc = ((double)value / (double)_maxValue);
            int _newValue = (int)(_calc * 100);
            //Painel.progressBar.Value = _progress;
            //Painel.progressBarPercentLabel.Text = _progress + "%";
            return value;
        }
        public static void Reset()
        {
            Progress = 0;
            ProgressMaxValue = 0;
            Painel.progressBar.Value = 0;
            Painel.progressBar.Maximum = 1;
            Painel.progressBarPercentLabel.Text = 0 + "%";
        }
        public static int SetMaxValue(int value)
        {
            Painel.progressBar.Maximum = value;
            ProgressMaxValue = value;
            return value;
        }
    }
}
