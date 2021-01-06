using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_2_商场收银软件2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0.0d;

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxType.Items.AddRange(new object[] { "正常收费", "打八折", "打七折", "打五折" });
            cbxType.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double totalPrices = 0.0d;

            switch (cbxType.SelectedIndex)
            {
                case 0:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
                    break;
                case 1:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.8;
                    break;
                case 2:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.7;
                    break;
                case 3:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.5;
                    break;
            }

            total = total + totalPrices;
            lbxList.Text += $"单价：{txtPrice.Text},数量：{txtNum.Text},合计：{totalPrices.ToString()}\r\n";
            lblResult.Text = total.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbxList_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
