using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2(List<TaskModel> taskModelList)
        {
            InitializeComponent();

            int[,] data = new int[5,10];//第一维是类型, 第二维是天数
            

            foreach(TaskModel taskmodel in taskModelList)
            {
                int day = WhichDay(taskmodel.date);

                if(day >= 10)
                {
                    break;//list是从新到旧开始遍历的,如果超过10天了, 就不用再遍历了
                }

                switch (taskmodel.tag)
                {
                    case "英语":
                        data[1,day] += taskmodel.duration;
                        break;
                    case "政治":
                        data[2,day] += taskmodel.duration;
                        break;
                    case "设计概论":
                        data[3,day] += taskmodel.duration;
                        break;
                    case "设计作品分析":
                        data[4,day] += taskmodel.duration;
                        break;
                }
                data[0,day] += taskmodel.duration;
            }

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 5; j++)//5个类别的数据
                {
                    chart1.Series[j].Points.AddXY(i, data[j,9-i]);
                }
            }
            
        }

        private int WhichDay(DateTime date)
        {
            DateTime now = DateTime.Now;
            TimeSpan timeSpan = now.Subtract(date);
            return (int)timeSpan.TotalDays;
        }
    }
}
