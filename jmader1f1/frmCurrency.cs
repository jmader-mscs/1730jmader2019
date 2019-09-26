using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jmader1f1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnCzechRepublic.BackgroundImage = picCzechRepublicDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnJamaica.BackgroundImage = picJamaicaDim.Image;
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();

        }

        private void BtnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnCzechRepublic.BackgroundImage = picCzechRepublicDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnJamaica.BackgroundImage = picJamaicaDim.Image;
            txtRate.Text = "0.68618961";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnCzechRepublic_Click(object sender, EventArgs e)
        {
            btnCzechRepublic.BackgroundImage = picCzechRepublic.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnJamaica.BackgroundImage = picJamaicaDim.Image;
            txtRate.Text = "0.04270937";
            lblCurrency.Text = btnCzechRepublic.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnEuro_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCzechRepublic.BackgroundImage = picCzechRepublicDim.Image;
            btnJamaica.BackgroundImage = picJamaicaDim.Image;
            txtRate.Text = "1.10447497";
            lblCurrency.Text = btnEuro.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnJamaica_Click(object sender, EventArgs e)
        {
            btnJamaica.BackgroundImage = picJamaica.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCzechRepublic.BackgroundImage = picCzechRepublicDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.00730798";
            lblCurrency.Text = btnJamaica.Text + ": ";
            txtCurrency.Focus();
        }

        private void LblCurrency_Click(object sender, EventArgs e)
        {

        }

        private void calcUSD(object sender, EventArgs e)
        {
            
        }

        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
                Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)
                    ).ToString("0.00");
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDollars.Text) + Convert.ToDecimal(txtTotalUSD.Text)
                    ).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
            txtCurrency.Focus();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtTotalUSD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtUSDollars_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnCzechRepublic.BackgroundImage = picCzechRepublicDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnJamaica.BackgroundImage = picJamaicaDim.Image;
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
            txtCurrency.Text = "0.00";

        }
    }
}
