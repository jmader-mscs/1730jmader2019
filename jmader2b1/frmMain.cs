using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jmader2b1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = 10m;
            decimal rateAustralia = 0.68618961m;
            decimal usdAustralia = amountAustralia * rateAustralia;

            decimal amountCzech = 100m;
            decimal rateCzech = 0.04270937m;
            decimal usdCzech = amountCzech * rateCzech;

            decimal amountEuro = 100m;
            decimal rateEuro = 1.10447497m;
            decimal usdEuro = amountEuro * rateEuro;

            decimal amountJamaica = 100m;
            decimal rateJamaica = 0.00730798m;
            decimal usdJamaica = amountJamaica * rateJamaica;

            decimal totalUSD = usdAustralia + usdCzech + usdEuro + usdJamaica;

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
                    Convert.ToDecimal(txtUSDAustralia.Text) + Convert.ToDecimal(txtUSDCzechRepublic.Text) + Convert.ToDecimal(txtUSDEuro.Text) + Convert.ToDecimal(txtUSDJamaica.Text)
                        ).ToString("0.00");
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
    }
    }

