using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace c__practive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*  //每斤购买单价
              double price = 1.9;
              //购买数量买6斤
              int count = 6;
              //折扣价格为7.5折
              double discount = 0.75;
              //用于存放总价的变量
              double totalPrice;
              //计算折前总价
              totalPrice = price * count;
              //判断总价有无超过十元
              if (totalPrice > 10)
              {
                  totalPrice = totalPrice * discount;//复合赋值，超过十元进行折价处理

              }
              MessageBox.Show(totalPrice.ToString());*/
            //创建变量price为西瓜每斤购买价格
            double price = 1.9;
            //创建变量count为购买总数
            int count = 16;
            //创建变量discount为折扣价格
            double discount = 0.75;
            //创建变量totalPrice为总价格
            double totalPrice;
            //总价格等于西瓜每斤购买价格*购买总数
            totalPrice = price * count;
            //创建变量d为总价格除10，这里使用了强制转换的(int)类型
            int d= (int)(totalPrice/10);
            //设置变量totalten为10的数量初始值为0
            double totalten = 0;
            //设置变量i为0，如果i小于变量d，则进行下列循环，且i自增
           for (int i = 0; i < d; i++)
            {
                      
                totalten = totalten+10 * discount;
            }
           //设置变量为总价对10的取余
            double y = totalPrice % 10;
           //计算总价
            totalPrice = totalten + y;
            //系统给出总价提示
            MessageBox.Show(totalPrice.ToString());
        }
    }
}
