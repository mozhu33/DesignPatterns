using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_4_商场收银_策略模式_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxType.Items.AddRange(new object[] { "正常收费", "满300返100", "打8折" });
            cbxType.SelectedIndex = 0;
        }

        double total = 0.0d;

        private void btnOk_Click(object sender, EventArgs e)
        {
            CashContext cc = null;
            switch (cbxType.SelectedItem.ToString())
            {
                case "正常收费":
                    cc = new CashContext(new CashNormal());
                    break;
                case "满300返100":
                    cc = new CashContext(new CashReturn("300", "100"));
                    break;
                case "打8折":
                    cc = new CashContext(new CashRebate("0.8"));
                    break;
            }

            double totalPrices = 0d;
            totalPrices = cc.GetResult(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
            total = total + totalPrices;
            lbxList.Text += $"单价：{txtPrice.Text},数量：{txtNum.Text},合计：{totalPrices.ToString()}\r\n";
            lblResult.Text = total.ToString();
        }
    }
}
