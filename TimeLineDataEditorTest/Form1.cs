using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeLineDataEditor;

namespace TimeLineDataEditorTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeLineDataJsCode TimeLineDataJsCode = new TimeLineDataJsCode();
            //读取已有的js文件
            TimeLineDataJsCode.ReadFromJsFile(@"H:\VSProjects\TimeLineDataEditor\data.js");            
            List<TimeLineData> dataList = TimeLineDataJsCode.Find("草长莺飞");
            foreach(TimeLineData data in dataList)
            {
                TimeLineDataJsCode.Remove(data);
            }            
            TimeLineDataJsCode.WriteToJsFile(@"H:\AA.JS");
        }
    }
}
