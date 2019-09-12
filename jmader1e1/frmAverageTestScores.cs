using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jmader1e1
{
    public partial class frmAverageTestScores : Form
    {
        public frmAverageTestScores()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Text = "0";
            txtTest2.Text = "0";
            txtTest3.Text = "0";
            txtTestAverage.Text = "";

            txtTest1.Focus();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtTestAverage.Text = (
                Convert.ToDecimal(txtTest1.Text) + Convert.ToDecimal(txtTest2.Text) + Convert.ToDecimal(txtTest3.Text)
                ) .ToString("");
            txtTestAverage.Text = 
                (Convert.ToDecimal(txtTestAverage.Text) /3m)
                    .ToString("0.00");
        }


        private void TxtTest1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtTest2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTest3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTestAverage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
