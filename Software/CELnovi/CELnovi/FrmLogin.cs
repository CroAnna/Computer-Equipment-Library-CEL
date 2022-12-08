using CELnovi.Models;
using CELnovi.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELnovi
{
    public partial class FrmLogin : Form
    {
        public static Zaposlenik LogiraniZaposlenik { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void labelCEL_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginClick(object sender, EventArgs e)
        {
            LogiraniZaposlenik = RepozitorijZaposlenika.GetZaposlenik(txtKorisnickoIme.Text);
            var Logirani = LogiraniZaposlenik;

            if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (LogiraniZaposlenik != null && LogiraniZaposlenik.ProvjeriLozinku(txtLozinka.Text))
                {
                    FrmOprema frmOprema = new FrmOprema();
                    Hide();
                    frmOprema.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }
    }
}
