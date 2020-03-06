using System;
using System.Collections.Generic;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace AlarmApp
{
    public partial class WoWBuffTimer : Form
    {
        private List<AlarmData> _alarms;
        private readonly SoundPlayer _sp;
        private readonly Assembly _ass;
        public WoWBuffTimer()
        {
            InitializeComponent();

            beforePicker1.Format = DateTimePickerFormat.Custom;
            beforePicker1.CustomFormat = "mm";
            beforePicker2.Format = DateTimePickerFormat.Custom;
            beforePicker2.CustomFormat = "mm";
            beforePicker3.Format = DateTimePickerFormat.Custom;
            beforePicker3.CustomFormat = "mm";
            alarm1Picker.Format = DateTimePickerFormat.Custom;
            alarm1Picker.CustomFormat = "HH:mm";
            alarm2Picker.Format = DateTimePickerFormat.Custom;
            alarm2Picker.CustomFormat = "HH:mm";
            alarm3Picker.Format = DateTimePickerFormat.Custom;
            alarm3Picker.CustomFormat = "HH:mm";

            notifyIcon.Visible = false;

            _ass = Assembly.GetExecutingAssembly();
            _sp = new SoundPlayer(_ass.GetManifestResourceStream("AlarmApp.alarm.wav"));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _alarms = CreateAlarmData();
            var copyAlarmData = new List<AlarmData>(_alarms);

            foreach (var data in copyAlarmData)
            {
                if (!data.Active) continue;
                if (DateTime.Now > data.AlarmTime)
                {
                    _alarms.Remove(data);
                    _sp.Play();
                    data.Checkbox.Checked = false;
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _alarms = CreateAlarmData();
            if ((alarm1.Checked || alarm2.Checked || alarm3.Checked) && !timer.Enabled)
            {
                timer.Start();
                startButton.Text = "Stop";
                this.Text = "WoW buff timer - Started";
            }
            else
            {
                timer.Stop();
                startButton.Text = "Start";
                this.Text = "WoW buff timer - Stopped";
            }
        }

        private List<AlarmData> CreateAlarmData()
        {
            var alarms = new List<AlarmData>();
            var a1 = new AlarmData(alarm1.Checked, CalcuateAlarmTime(alarm1Picker.Value, BuffDuration.WCB, beforePicker1.Value.Minute, beforePicker1.Checked), alarm1);
            var a2 = new AlarmData(alarm2.Checked, CalcuateAlarmTime(alarm2Picker.Value, BuffDuration.NEF, beforePicker2.Value.Minute, beforePicker2.Checked), alarm2);
            var a3 = new AlarmData(alarm3.Checked, CalcuateAlarmTime(alarm3Picker.Value, BuffDuration.ONY, beforePicker3.Value.Minute, beforePicker3.Checked), alarm3);

            alarms.Add(a1);
            alarms.Add(a2);
            alarms.Add(a3);

            return alarms;
        }

        private DateTime CalcuateAlarmTime(DateTime lastBuff, BuffDuration buffTime, int subtractTime, bool timeBefore)
        {
            if (!timeBefore)
            {
                return lastBuff.AddHours((int) buffTime);
            }
            else
            {
                var time = lastBuff.AddHours((int) buffTime).Subtract(new TimeSpan(0,subtractTime,0));
                return time;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_sp.IsLoadCompleted)
            {
                MessageBox.Show("No sound is playing you bloody idiot!", "WTF YOU DOING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _sp.Stop();
            }
        }

        private void WoWBuffTimer_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            this.Show();
            this.Activate();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
