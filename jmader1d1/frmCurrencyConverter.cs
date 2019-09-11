using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jmader1d1
{
    public partial class jmader1d1 : Form
    {
        public jmader1d1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.68618961";
            txtAmountCzechRepublic.Text = "0.00";
            txtRateCzechRepublic.Text = "0.04270937";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.10447497";
            txtAmountJamaica.Text = "0.00";
            txtRateJamaica.Text = "0.00730798";
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                99.99m
                ).ToString("0.00");
        }

        private void TxtRateAustralia_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUSDAustralia_TextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                    Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)
                        ).ToString("0.00");
            txtUSDCzechRepublic.Text = (
                    Convert.ToDecimal(txtAmountCzechRepublic.Text) * Convert.ToDecimal(txtRateCzechRepublic.Text)
                        ).ToString("0.00");
            txtUSDEuro.Text = (
                    Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtRateEuro.Text)
                        ).ToString("0.00");
            txtUSDJamaica.Text = (
                    Convert.ToDecimal(txtAmountJamaica.Text) * Convert.ToDecimal(txtRateJamaica.Text)
                        ).ToString("0.00");
            txtTotalUSD.Text = (
                    Convert.ToDecimal(txtUSDAustralia.Text) + Convert.ToDecimal(txtUSDCzechRepublic.Text) + Convert.ToDecimal(txtAmountEuro.Text) + Convert.ToDecimal(txtAmountJamaica.Text)
                        ).ToString("0.00");
        }

        private void TxtTotalUSD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
