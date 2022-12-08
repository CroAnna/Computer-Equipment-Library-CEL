using CELnovi.Models;
using CELnovi.Repositories;
using DBLayer;
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
    public partial class FrmUnosOpreme : Form
    {
        public FrmUnosOpreme(Oprema odabranaOprema)
        {
            InitializeComponent();
        }

        private void FrmUnosOpreme_Load(object sender, EventArgs e)
        {
            List<IzvorFinanciranjaKlasa> izvoriFinanciranja = RepozitorijIzvoraFinanciranja.GetIzvoreFinanciranja();
            cboIzvorFinanciranja.DataSource = izvoriFinanciranja;
        }

        private void btnPopisClick(object sender, EventArgs e)
        {
            FrmOprema frmOprema = new FrmOprema(); 
            Hide();
            frmOprema.ShowDialog();
            Close();
        }

        private void cboIzvorFinanciranja_OdabraniIndexPromijenjen(object sender, EventArgs e)
        {
            IzvorFinanciranjaKlasa trenutniIzvor = cboIzvorFinanciranja.SelectedItem as IzvorFinanciranjaKlasa; 
        }

        private void btnUnesiClick(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string naziv = txtNazivOpreme.Text;
            string vrsta = txtvrstaOpreme.Text;
            string datVrPrimke = txtDatVrPrimke.Text;
            string nazivProjekta = txtNazivProjekta.Text;
            string izvorFinanciranja = cboIzvorFinanciranja.Text;
            string opisOpreme = txtOpisOpreme.Text;
            string osobaNabave = txtOsobaNabave.Text;
            string osobaPrimke = txtOsobaPrimke.Text;

            Oprema novaOprema = new Oprema();

            novaOprema.Id = id;
            novaOprema.Naziv = naziv;
            novaOprema.Vrsta = vrsta;
            novaOprema.DatVrPrimke = datVrPrimke;
            novaOprema.NazivProjekta = nazivProjekta;
            novaOprema.IzvorFinanciranja = RepozitorijIzvoraFinanciranja.GetIzvorFinanciranja(cboIzvorFinanciranja.SelectedIndex+1); 
            novaOprema.OpisOpreme = opisOpreme;
            novaOprema.OsobaNabave = osobaNabave;
            novaOprema.OsobaPrimke = osobaPrimke;

            RepozitorijOpreme.UmetniOpremu(novaOprema);

            MessageBox.Show("Uspješan unos!");

            FrmOprema frmOprema = new FrmOprema();
            Hide();
            frmOprema.ShowDialog();
            Close();
        }
    }
}
