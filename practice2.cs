using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_practive2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }AcceptRejectRule.0

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化数组
            string[] calssStudents = new string[] { "张三", "李四", "王五", "赵六", "田七", "周八" };
            //获取数组长度 
            int studentCount =  calssStudents.Length;
            //通过for循环遍历数组
            for (int i = 0; i < studentCount; i++)
            {
                //如果遍历的元素时找到赵六，则进入判断体
                if (calssStudents[i]=="赵六")
                {
                    MessageBox.Show("找到了" + calssStudents[i]+",送他回家");
                    break;//跳出循环
                }
            }
        }
    }
}
