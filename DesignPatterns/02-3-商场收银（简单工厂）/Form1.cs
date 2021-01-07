﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_3_商场收银_简单工厂_
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
            CashSuper csSuper = CashFactory.CreateCashAccept(cbxType.SelectedItem.ToString());
            double totalPrices = 0d;
            totalPrices = csSuper.AcceptCash((Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text)));
            total = total + totalPrices;
            lbxList.Text += $"单价：{txtPrice.Text},数量：{txtNum.Text},合计：{totalPrices.ToString()}\r\n";
            lblResult.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxType.Items.AddRange(new object[] { "正常收费", "满300返100", "打8折" });
            cbxType.SelectedIndex = 0;
        }
    }
}
