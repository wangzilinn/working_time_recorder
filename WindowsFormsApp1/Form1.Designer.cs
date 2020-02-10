using System;

namespace WindowsFormsApp1
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
            this.saveButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tagListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.saveShutdownButton = new System.Windows.Forms.Button();
            this.saveSleepButton = new System.Windows.Forms.Button();
            this.item = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).BeginInit();
            this.item.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(193, 9);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "仅保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.Location = new System.Drawing.Point(193, 90);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(75, 23);
            this.statisticsButton.TabIndex = 2;
            this.statisticsButton.Text = "查看统计";
            this.statisticsButton.UseVisualStyleBackColor = true;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(150, 120);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(114, 52);
            this.noteTextBox.TabIndex = 3;
            this.noteTextBox.TextChanged += new System.EventHandler(this.noteTextBox_TextChanged);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startDateTimePicker.Location = new System.Drawing.Point(71, 11);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(112, 21);
            this.startDateTimePicker.TabIndex = 4;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "开始时间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "结束时间:";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endDateTimePicker.Location = new System.Drawing.Point(71, 41);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(112, 21);
            this.endDateTimePicker.TabIndex = 7;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "持续时间:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "小时";
            // 
            // minuteNumericUpDown
            // 
            this.minuteNumericUpDown.Location = new System.Drawing.Point(132, 70);
            this.minuteNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteNumericUpDown.Name = "minuteNumericUpDown";
            this.minuteNumericUpDown.Size = new System.Drawing.Size(35, 21);
            this.minuteNumericUpDown.TabIndex = 11;
            this.minuteNumericUpDown.ValueChanged += new System.EventHandler(this.minuteNumericUpDown_ValueChanged);
            // 
            // hourNumericUpDown
            // 
            this.hourNumericUpDown.Location = new System.Drawing.Point(71, 70);
            this.hourNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.hourNumericUpDown.Name = "hourNumericUpDown";
            this.hourNumericUpDown.Size = new System.Drawing.Size(35, 21);
            this.hourNumericUpDown.TabIndex = 12;
            this.hourNumericUpDown.ValueChanged += new System.EventHandler(this.hourNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "分";
            // 
            // tagListBox
            // 
            this.tagListBox.FormattingEnabled = true;
            this.tagListBox.ItemHeight = 12;
            this.tagListBox.Location = new System.Drawing.Point(12, 120);
            this.tagListBox.Name = "tagListBox";
            this.tagListBox.Size = new System.Drawing.Size(114, 52);
            this.tagListBox.TabIndex = 14;
            this.tagListBox.SelectedIndexChanged += new System.EventHandler(this.tagListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "任务标签:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "备注:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.item;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // saveShutdownButton
            // 
            this.saveShutdownButton.Location = new System.Drawing.Point(193, 36);
            this.saveShutdownButton.Name = "saveShutdownButton";
            this.saveShutdownButton.Size = new System.Drawing.Size(75, 23);
            this.saveShutdownButton.TabIndex = 17;
            this.saveShutdownButton.Text = "保存并关机";
            this.saveShutdownButton.UseVisualStyleBackColor = true;
            this.saveShutdownButton.Click += new System.EventHandler(this.saveShutdownButton_Click);
            // 
            // saveSleepButton
            // 
            this.saveSleepButton.Location = new System.Drawing.Point(193, 63);
            this.saveSleepButton.Name = "saveSleepButton";
            this.saveSleepButton.Size = new System.Drawing.Size(75, 23);
            this.saveSleepButton.TabIndex = 18;
            this.saveSleepButton.Text = "保存并睡眠";
            this.saveSleepButton.UseVisualStyleBackColor = true;
            this.saveSleepButton.Click += new System.EventHandler(this.saveSleepButton_Click);
            // 
            // item
            // 
            this.item.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.item.Name = "退出";
            this.item.Size = new System.Drawing.Size(153, 48);
            this.item.Text = "退出";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 180);
            this.Controls.Add(this.saveSleepButton);
            this.Controls.Add(this.saveShutdownButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tagListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hourNumericUpDown);
            this.Controls.Add(this.minuteNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.saveButton);
            this.Name = "Form1";
            this.Text = "学习记录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).EndInit();
            this.item.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown minuteNumericUpDown;
        private System.Windows.Forms.NumericUpDown hourNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox tagListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button saveShutdownButton;
        private System.Windows.Forms.Button saveSleepButton;
        private System.Windows.Forms.ContextMenuStrip item;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

