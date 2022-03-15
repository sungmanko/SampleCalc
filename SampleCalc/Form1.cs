using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCalc
{
    public partial class Form1 : Form
    {
        clsCalc cc = new clsCalc();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtResult.Text = cc.Calc(txtFirst.Text, txtSecond.Text);
        }

        /// <summary>
        /// クリア処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Text = string.Empty;
            txtSecond.Text = string.Empty;
            txtResult.Text = string.Empty;
        }
    }
}
