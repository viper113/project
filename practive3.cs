using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_practive_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //初始化数组
            string[] classStudents = { "张三", "李四", "王五", "赵六", "田七", "周八" };
            //创建变量i作为索引，以获取数组的值
            int i = 0;
            //存放数组遍历到的学生名
            string student = "";
            //作为标记使用，便于程序判断是否找到了指定学生
            bool isFind = true;
            while (student != "赵六")
            {
                //如果索引值已经大于等于数组的长度，则说明没有找到指定的学生
                if (i >= classStudents.Length) {
                    MessageBox.Show("没有找到要找的人");
                    //此时isFind标记为false，告诉系统，没有找到指定人
                    isFind = false;
                   //跳出循环
                    break;
                } 
                //将遍历的数组元素赋值给变量student
                student = classStudents[i++];   
            }
            //如果isFind为真，则说明找到指定目标，系统弹出指示
           if(isFind) MessageBox.Show("找到了"+student+"送他回家");
        }
    }
}
