using System;
using System.Windows.Forms;

namespace AlarmApp
{
    public class AlarmData
    {
        public bool Active { get; set; }
        public DateTime AlarmTime { get; set; }
        public CheckBox Checkbox { get; set; }

        public AlarmData(bool active, DateTime alarmTime, CheckBox check)
        {
            Active = active;
            AlarmTime = alarmTime;
            Checkbox = check;
        }
    }
}