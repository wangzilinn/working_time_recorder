using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int taskDuration = 0;
        private List<TaskModel> taskModelList;
        private bool updateFromTimePicker = false;
        private bool updateFromNumericUpDown = false;

        public Form1()
        {
            InitializeComponent();
            //初始化值:
            tagListBox.Items.Add("英语");
            tagListBox.Items.Add("政治");
            tagListBox.Items.Add("设计概论");
            tagListBox.Items.Add("设计作品分析");

            taskModelList = LoadFile<List<TaskModel>>("data.txt");

            //第一次使用时无法读取文件, 返回null
            if(taskModelList == null)
            {
                taskModelList = new List<TaskModel>();
            }
                
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Save();

        }

        private void saveShutdownButton_Click(object sender, EventArgs e)
        {
            Save();
            Process.Start("shutdown.exe", "-s -t 0");//计时关机
        }

        private void saveSleepButton_Click(object sender, EventArgs e)
        {
            Save();
            SetSuspendState(false, true, true);
        }

        private void tagListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(taskModelList);
            form2.Show();
        }

        private void hourNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

            if (updateFromTimePicker)
            {
                return;
            }
            updateFromNumericUpDown = true;
            CalculateTaskDurationFromNumericUpDown();
            UpdateStartDateTimPicker();
            updateFromNumericUpDown = false;
        }

        private void minuteNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (updateFromTimePicker)
            {
                return;
            }
            updateFromNumericUpDown = true;
            CalculateTaskDurationFromNumericUpDown();
            UpdateStartDateTimPicker();
            updateFromNumericUpDown = false;

            
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (updateFromNumericUpDown)
            {
                return;
            }
            updateFromTimePicker = true;
            CalculateTaskDurationFromTimePicker();
            UpdateTimeNumericUpDown();
            updateFromTimePicker = false;

            
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (updateFromNumericUpDown)
            {
                return;
            }
            updateFromTimePicker = true;
            CalculateTaskDurationFromTimePicker();
            UpdateTimeNumericUpDown();
            updateFromTimePicker = false;

      

        }

        private void CalculateTaskDurationFromTimePicker()
        {
            int start = startDateTimePicker.Value.Hour * 60 + startDateTimePicker.Value.Minute;
            int end = endDateTimePicker.Value.Hour * 60 + endDateTimePicker.Value.Minute;

            taskDuration = (int)endDateTimePicker.Value.Subtract(startDateTimePicker.Value).TotalMinutes;

        }

        private void CalculateTaskDurationFromNumericUpDown()
        {
            int hour = Convert.ToInt32(hourNumericUpDown.Value);
            int minutes = Convert.ToInt32(minuteNumericUpDown.Value);

            taskDuration = hour * 60 + minutes;     
        }

        private void UpdateTimeNumericUpDown()
        {
            hourNumericUpDown.Value = taskDuration / 60;
            minuteNumericUpDown.Value = taskDuration % 60; 
 
        }

        //修改持续之间后默认只有开始时间改变
        private void UpdateStartDateTimPicker()
        {
            startDateTimePicker.Value = DateTime.Now.AddMinutes(-taskDuration);
        }

        private void UpdateTaskModelList()
        {
            TaskModel taskModel = new TaskModel();
            taskModel.date = DateTime.Now;
            taskModel.duration = taskDuration;
            taskModel.tag = (String)tagListBox.SelectedItem;
            taskModel.note = noteTextBox.Text;

            taskModelList.Insert(0, taskModel);//在列表的头部添加, 这样列表的数据
        
        }

        private void Save()
        {
            UpdateTaskModelList();

            string jsonData = JsonConvert.SerializeObject(taskModelList);

            Console.WriteLine(jsonData);
            SaveFile(taskModelList, "data.txt");
        }

        private void SaveFile<T>(T ins, string fullPath)
        {
            
            using (var stream = new StreamWriter(fullPath, false))
            {
                string str = JsonConvert.SerializeObject(ins);
                stream.Write(str);
                stream.Flush();
                stream.Close();
            }

        }

        public static T LoadFile<T>(string fullPath)
        {
            try
            {
                var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using (var stream = new StreamReader(fs))
                {
                    return JsonConvert.DeserializeObject<T>(stream.ReadToEnd());
                }
            }catch(Exception e)
            {
                return default(T);
            }
      

        }

        [DllImport("PowrProf.dll",CharSet = CharSet.Auto, ExactSpelling =true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)   //判断窗体是不是最小化
                this.WindowState = FormWindowState.Normal;   //如果是最小化就把窗体状态改为默认大小
            this.Activate();  //激活窗体并赋予焦点，这句话可以不写
            this.ShowInTaskbar = true;   //在Windows任务栏中显示窗体。
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;    //取消窗体关闭事件
            this.WindowState = FormWindowState.Minimized;   //最小化窗口
            this.ShowInTaskbar = false;		//在Windows任务栏中不显示窗体
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
