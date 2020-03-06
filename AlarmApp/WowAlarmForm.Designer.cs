namespace AlarmApp
{
    partial class WoWBuffTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WoWBuffTimer));
            this.alarm1 = new System.Windows.Forms.CheckBox();
            this.alarm3 = new System.Windows.Forms.CheckBox();
            this.alarm2 = new System.Windows.Forms.CheckBox();
            this.alarm1Picker = new System.Windows.Forms.DateTimePicker();
            this.alarm3Picker = new System.Windows.Forms.DateTimePicker();
            this.alarm2Picker = new System.Windows.Forms.DateTimePicker();
            this.startButton = new System.Windows.Forms.Button();
            this.beforePicker1 = new System.Windows.Forms.DateTimePicker();
            this.beforePicker2 = new System.Windows.Forms.DateTimePicker();
            this.beforePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // alarm1
            // 
            this.alarm1.AutoSize = true;
            this.alarm1.Location = new System.Drawing.Point(12, 9);
            this.alarm1.Name = "alarm1";
            this.alarm1.Size = new System.Drawing.Size(180, 17);
            this.alarm1.TabIndex = 0;
            this.alarm1.Text = "Warchiefs blessing (3 hour reset)";
            this.alarm1.UseVisualStyleBackColor = true;
            // 
            // alarm3
            // 
            this.alarm3.AutoSize = true;
            this.alarm3.Location = new System.Drawing.Point(12, 66);
            this.alarm3.Name = "alarm3";
            this.alarm3.Size = new System.Drawing.Size(186, 17);
            this.alarm3.TabIndex = 6;
            this.alarm3.Text = "Onyxia dragonslayer (6 hour reset)";
            this.alarm3.UseVisualStyleBackColor = true;
            // 
            // alarm2
            // 
            this.alarm2.AutoSize = true;
            this.alarm2.Location = new System.Drawing.Point(12, 38);
            this.alarm2.Name = "alarm2";
            this.alarm2.Size = new System.Drawing.Size(194, 17);
            this.alarm2.TabIndex = 3;
            this.alarm2.Text = "Nefarian dragonslayer (8 hour reset)";
            this.alarm2.UseVisualStyleBackColor = true;
            // 
            // alarm1Picker
            // 
            this.alarm1Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.alarm1Picker.Location = new System.Drawing.Point(205, 7);
            this.alarm1Picker.Name = "alarm1Picker";
            this.alarm1Picker.ShowUpDown = true;
            this.alarm1Picker.Size = new System.Drawing.Size(60, 20);
            this.alarm1Picker.TabIndex = 1;
            // 
            // alarm3Picker
            // 
            this.alarm3Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.alarm3Picker.Location = new System.Drawing.Point(205, 64);
            this.alarm3Picker.Name = "alarm3Picker";
            this.alarm3Picker.ShowUpDown = true;
            this.alarm3Picker.Size = new System.Drawing.Size(60, 20);
            this.alarm3Picker.TabIndex = 7;
            // 
            // alarm2Picker
            // 
            this.alarm2Picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.alarm2Picker.Location = new System.Drawing.Point(205, 36);
            this.alarm2Picker.Name = "alarm2Picker";
            this.alarm2Picker.ShowUpDown = true;
            this.alarm2Picker.Size = new System.Drawing.Size(60, 20);
            this.alarm2Picker.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 89);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(317, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // beforePicker1
            // 
            this.beforePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.beforePicker1.Location = new System.Drawing.Point(394, 7);
            this.beforePicker1.Name = "beforePicker1";
            this.beforePicker1.ShowCheckBox = true;
            this.beforePicker1.ShowUpDown = true;
            this.beforePicker1.Size = new System.Drawing.Size(59, 20);
            this.beforePicker1.TabIndex = 2;
            // 
            // beforePicker2
            // 
            this.beforePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.beforePicker2.Location = new System.Drawing.Point(394, 36);
            this.beforePicker2.Name = "beforePicker2";
            this.beforePicker2.ShowCheckBox = true;
            this.beforePicker2.ShowUpDown = true;
            this.beforePicker2.Size = new System.Drawing.Size(59, 20);
            this.beforePicker2.TabIndex = 5;
            // 
            // beforePicker3
            // 
            this.beforePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.beforePicker3.Location = new System.Drawing.Point(394, 63);
            this.beforePicker3.Name = "beforePicker3";
            this.beforePicker3.ShowCheckBox = true;
            this.beforePicker3.ShowUpDown = true;
            this.beforePicker3.Size = new System.Drawing.Size(59, 20);
            this.beforePicker3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Alarm before in minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Alarm before in minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Alarm before in minutes";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Stop active alarm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "WoW Alarm App has been minimized";
            this.notifyIcon.BalloonTipTitle = "WoW Alarm App";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "WoW Alarm App";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // WoWBuffTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 128);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.beforePicker3);
            this.Controls.Add(this.beforePicker2);
            this.Controls.Add(this.beforePicker1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.alarm2Picker);
            this.Controls.Add(this.alarm3Picker);
            this.Controls.Add(this.alarm1Picker);
            this.Controls.Add(this.alarm2);
            this.Controls.Add(this.alarm3);
            this.Controls.Add(this.alarm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WoWBuffTimer";
            this.Text = "WoW buff timers";
            this.Resize += new System.EventHandler(this.WoWBuffTimer_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox alarm1;
        private System.Windows.Forms.CheckBox alarm3;
        private System.Windows.Forms.CheckBox alarm2;
        private System.Windows.Forms.DateTimePicker alarm1Picker;
        private System.Windows.Forms.DateTimePicker alarm3Picker;
        private System.Windows.Forms.DateTimePicker alarm2Picker;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DateTimePicker beforePicker1;
        private System.Windows.Forms.DateTimePicker beforePicker2;
        private System.Windows.Forms.DateTimePicker beforePicker3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

