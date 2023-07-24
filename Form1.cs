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
            double price = 1.9;
            int count = 16;
            double discount = 0.75;
            double totalPrice;
            totalPrice = price * count;
            int d= (int)(totalPrice/10);
            double totalten = 0;
           for (int i = 3; i < d; i++)
            {
                totalten = totalten+10 * discount;
            }
            double y = totalPrice % 10;
            totalPrice = totalPrice + y;
            MessageBox.Show(totalPrice.ToString());
        }
    }
}
