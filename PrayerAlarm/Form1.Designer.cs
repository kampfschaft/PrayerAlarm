namespace PrayerAlarm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.listState = new System.Windows.Forms.ComboBox();
            this.listZone = new System.Windows.Forms.ComboBox();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZone = new System.Windows.Forms.Label();
            this.labelFajr = new System.Windows.Forms.Label();
            this.labelZuhr = new System.Windows.Forms.Label();
            this.labelAsr = new System.Windows.Forms.Label();
            this.labelMaghrib = new System.Windows.Forms.Label();
            this.labelEsha = new System.Windows.Forms.Label();
            this.dateTimePickerFajr = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerZuhr = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAsr = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerMaghrib = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEsha = new System.Windows.Forms.DateTimePicker();
            this.timeFajr = new System.Windows.Forms.Label();
            this.timeZuhr = new System.Windows.Forms.Label();
            this.timeAsr = new System.Windows.Forms.Label();
            this.timeMaghrib = new System.Windows.Forms.Label();
            this.timeEsha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Prayer Alarm";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // listState
            // 
            this.listState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listState.FormattingEnabled = true;
            this.listState.Items.AddRange(new object[] {
            "Johor",
            "Kedah",
            "Kelantan",
            "Kuala Lumpur",
            "Melaka",
            "Negeri Sembilan",
            "Pahang",
            "Perak",
            "Perlis",
            "Pulau Pinang",
            "Sabah",
            "Sarawak",
            "Selangor",
            "Terengganu"});
            this.listState.Location = new System.Drawing.Point(54, 10);
            this.listState.Name = "listState";
            this.listState.Size = new System.Drawing.Size(213, 21);
            this.listState.Sorted = true;
            this.listState.TabIndex = 0;
            this.listState.Text = "Select State";
            // 
            // listZone
            // 
            this.listZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listZone.FormattingEnabled = true;
            this.listZone.Location = new System.Drawing.Point(54, 37);
            this.listZone.Name = "listZone";
            this.listZone.Size = new System.Drawing.Size(213, 21);
            this.listZone.TabIndex = 1;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(13, 13);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(35, 13);
            this.labelState.TabIndex = 2;
            this.labelState.Text = "State:";
            // 
            // labelZone
            // 
            this.labelZone.AutoSize = true;
            this.labelZone.Location = new System.Drawing.Point(13, 40);
            this.labelZone.Name = "labelZone";
            this.labelZone.Size = new System.Drawing.Size(35, 13);
            this.labelZone.TabIndex = 3;
            this.labelZone.Text = "Zone:";
            // 
            // labelFajr
            // 
            this.labelFajr.AutoSize = true;
            this.labelFajr.Location = new System.Drawing.Point(13, 96);
            this.labelFajr.Name = "labelFajr";
            this.labelFajr.Size = new System.Drawing.Size(27, 13);
            this.labelFajr.TabIndex = 4;
            this.labelFajr.Text = "Fajr:";
            // 
            // labelZuhr
            // 
            this.labelZuhr.AutoSize = true;
            this.labelZuhr.Location = new System.Drawing.Point(13, 126);
            this.labelZuhr.Name = "labelZuhr";
            this.labelZuhr.Size = new System.Drawing.Size(32, 13);
            this.labelZuhr.TabIndex = 5;
            this.labelZuhr.Text = "Zuhr:";
            // 
            // labelAsr
            // 
            this.labelAsr.AutoSize = true;
            this.labelAsr.Location = new System.Drawing.Point(13, 156);
            this.labelAsr.Name = "labelAsr";
            this.labelAsr.Size = new System.Drawing.Size(25, 13);
            this.labelAsr.TabIndex = 6;
            this.labelAsr.Text = "Asr:";
            // 
            // labelMaghrib
            // 
            this.labelMaghrib.AutoSize = true;
            this.labelMaghrib.Location = new System.Drawing.Point(13, 186);
            this.labelMaghrib.Name = "labelMaghrib";
            this.labelMaghrib.Size = new System.Drawing.Size(48, 13);
            this.labelMaghrib.TabIndex = 7;
            this.labelMaghrib.Text = "Maghrib:";
            // 
            // labelEsha
            // 
            this.labelEsha.AutoSize = true;
            this.labelEsha.Location = new System.Drawing.Point(13, 216);
            this.labelEsha.Name = "labelEsha";
            this.labelEsha.Size = new System.Drawing.Size(34, 13);
            this.labelEsha.TabIndex = 8;
            this.labelEsha.Text = "Esha:";
            // 
            // dateTimePickerFajr
            // 
            this.dateTimePickerFajr.CustomFormat = "HH:mm";
            this.dateTimePickerFajr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFajr.Location = new System.Drawing.Point(212, 90);
            this.dateTimePickerFajr.Name = "dateTimePickerFajr";
            this.dateTimePickerFajr.ShowUpDown = true;
            this.dateTimePickerFajr.Size = new System.Drawing.Size(55, 20);
            this.dateTimePickerFajr.TabIndex = 9;
            // 
            // dateTimePickerZuhr
            // 
            this.dateTimePickerZuhr.CustomFormat = "HH:mm";
            this.dateTimePickerZuhr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerZuhr.Location = new System.Drawing.Point(212, 120);
            this.dateTimePickerZuhr.Name = "dateTimePickerZuhr";
            this.dateTimePickerZuhr.ShowUpDown = true;
            this.dateTimePickerZuhr.Size = new System.Drawing.Size(55, 20);
            this.dateTimePickerZuhr.TabIndex = 10;
            // 
            // dateTimePickerAsr
            // 
            this.dateTimePickerAsr.CustomFormat = "HH:mm";
            this.dateTimePickerAsr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAsr.Location = new System.Drawing.Point(212, 150);
            this.dateTimePickerAsr.Name = "dateTimePickerAsr";
            this.dateTimePickerAsr.ShowUpDown = true;
            this.dateTimePickerAsr.Size = new System.Drawing.Size(55, 20);
            this.dateTimePickerAsr.TabIndex = 11;
            // 
            // dateTimePickerMaghrib
            // 
            this.dateTimePickerMaghrib.CustomFormat = "HH:mm";
            this.dateTimePickerMaghrib.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMaghrib.Location = new System.Drawing.Point(212, 180);
            this.dateTimePickerMaghrib.Name = "dateTimePickerMaghrib";
            this.dateTimePickerMaghrib.ShowUpDown = true;
            this.dateTimePickerMaghrib.Size = new System.Drawing.Size(55, 20);
            this.dateTimePickerMaghrib.TabIndex = 12;
            // 
            // dateTimePickerEsha
            // 
            this.dateTimePickerEsha.CustomFormat = "HH:mm";
            this.dateTimePickerEsha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEsha.Location = new System.Drawing.Point(212, 210);
            this.dateTimePickerEsha.Name = "dateTimePickerEsha";
            this.dateTimePickerEsha.ShowUpDown = true;
            this.dateTimePickerEsha.Size = new System.Drawing.Size(55, 20);
            this.dateTimePickerEsha.TabIndex = 13;
            // 
            // timeFajr
            // 
            this.timeFajr.AutoSize = true;
            this.timeFajr.Location = new System.Drawing.Point(103, 96);
            this.timeFajr.Name = "timeFajr";
            this.timeFajr.Size = new System.Drawing.Size(34, 13);
            this.timeFajr.TabIndex = 14;
            this.timeFajr.Text = "00:00";
            // 
            // timeZuhr
            // 
            this.timeZuhr.AutoSize = true;
            this.timeZuhr.Location = new System.Drawing.Point(103, 126);
            this.timeZuhr.Name = "timeZuhr";
            this.timeZuhr.Size = new System.Drawing.Size(34, 13);
            this.timeZuhr.TabIndex = 15;
            this.timeZuhr.Text = "00:00";
            // 
            // timeAsr
            // 
            this.timeAsr.AutoSize = true;
            this.timeAsr.Location = new System.Drawing.Point(103, 156);
            this.timeAsr.Name = "timeAsr";
            this.timeAsr.Size = new System.Drawing.Size(34, 13);
            this.timeAsr.TabIndex = 16;
            this.timeAsr.Text = "00:00";
            // 
            // timeMaghrib
            // 
            this.timeMaghrib.AutoSize = true;
            this.timeMaghrib.Location = new System.Drawing.Point(103, 186);
            this.timeMaghrib.Name = "timeMaghrib";
            this.timeMaghrib.Size = new System.Drawing.Size(34, 13);
            this.timeMaghrib.TabIndex = 17;
            this.timeMaghrib.Text = "00:00";
            // 
            // timeEsha
            // 
            this.timeEsha.AutoSize = true;
            this.timeEsha.Location = new System.Drawing.Point(103, 216);
            this.timeEsha.Name = "timeEsha";
            this.timeEsha.Size = new System.Drawing.Size(34, 13);
            this.timeEsha.TabIndex = 18;
            this.timeEsha.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.timeEsha);
            this.Controls.Add(this.timeMaghrib);
            this.Controls.Add(this.timeAsr);
            this.Controls.Add(this.timeZuhr);
            this.Controls.Add(this.timeFajr);
            this.Controls.Add(this.dateTimePickerEsha);
            this.Controls.Add(this.dateTimePickerMaghrib);
            this.Controls.Add(this.dateTimePickerAsr);
            this.Controls.Add(this.dateTimePickerZuhr);
            this.Controls.Add(this.dateTimePickerFajr);
            this.Controls.Add(this.labelEsha);
            this.Controls.Add(this.labelMaghrib);
            this.Controls.Add(this.labelAsr);
            this.Controls.Add(this.labelZuhr);
            this.Controls.Add(this.labelFajr);
            this.Controls.Add(this.labelZone);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.listZone);
            this.Controls.Add(this.listState);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Prayer Alarm Interface";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox listState;
        private System.Windows.Forms.ComboBox listZone;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZone;
        private System.Windows.Forms.Label labelFajr;
        private System.Windows.Forms.Label labelZuhr;
        private System.Windows.Forms.Label labelAsr;
        private System.Windows.Forms.Label labelMaghrib;
        private System.Windows.Forms.Label labelEsha;
        private System.Windows.Forms.DateTimePicker dateTimePickerFajr;
        private System.Windows.Forms.DateTimePicker dateTimePickerZuhr;
        private System.Windows.Forms.DateTimePicker dateTimePickerAsr;
        private System.Windows.Forms.DateTimePicker dateTimePickerMaghrib;
        private System.Windows.Forms.DateTimePicker dateTimePickerEsha;
        private System.Windows.Forms.Label timeFajr;
        private System.Windows.Forms.Label timeZuhr;
        private System.Windows.Forms.Label timeAsr;
        private System.Windows.Forms.Label timeMaghrib;
        private System.Windows.Forms.Label timeEsha;
    }
}

