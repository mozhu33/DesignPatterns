using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_1_商场收银软件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0.0d;
        private void btnOk_Click(object sender, EventArgs e)
        {
            double totalPrice = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);

            total = total + totalPrice;

            lbxList.Text += $"单价：{txtPrice.Text},数量：{txtNum.Text},合计：{totalPrice.ToString()}\r\n";
            lblResult.Text = total.ToString();
        }
    }
}
