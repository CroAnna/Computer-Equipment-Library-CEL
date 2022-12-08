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
    public partial class FrmUpdate : Form
    {
        private Oprema oprema;

        public FrmUpdate(Oprema odabranaOprema)
        {
            InitializeComponent(); 
            oprema = odabranaOprema;
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            Text = oprema.Naziv;
            List<IzvorFinanciranjaKlasa> izvorFinanciranjaUpdate = RepozitorijIzvoraFinanciranja.GetIzvoreFinanciranja();
            cboIzvorFinanciranjaUpdate.DataSource = izvorFinanciranjaUpdate;

            txtIdUpdate.Text = oprema.Id.ToString();
            txtNazivOpremeUpdate.Text = oprema.Naziv;
            txtVrstaOpremeUpdate.Text= oprema.Vrsta;
            txtDatVrPrimkeUpdate.Text = oprema.DatVrPrimke;
            txtNazivProjektaUpdate.Text = oprema.NazivProjekta;
            txtOpisOpremeUpdate.Text = oprema.OpisOpreme;
            txtOsobaNabaveUpdate.Text = oprema.OsobaNabave;
            txtOsobaPrimkeUpdate.Text = oprema.OsobaPrimke;

            var tekstIzComboboxa = RepozitorijIzvoraFinanciranja.GetIzvorFinanciranja(oprema.IzvorFinanciranja.Id).ToString();
            cboIzvorFinanciranjaUpdate.Text = tekstIzComboboxa; 
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            FrmOprema frmOprema = new FrmOprema(); 
            Hide();
            frmOprema.ShowDialog();
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            int idUpdate = int.Parse(txtIdUpdate.Text);
            string nazivUpdate = txtNazivOpremeUpdate.Text;
            string vrstaUpdate = txtVrstaOpremeUpdate.Text;
            string datVrPrimkeUpdate = txtDatVrPrimkeUpdate.Text;
            string nazivProjektaUpdate = txtNazivProjektaUpdate.Text;
            int izvorFinanciranjaUpdate = cboIzvorFinanciranjaUpdate.SelectedIndex;
            string opisOpremeUpdate = txtOpisOpremeUpdate.Text;
            string osobaNabaveUpdate = txtOsobaNabaveUpdate.Text;
            string osobaPrimkeUpdate = txtOsobaPrimkeUpdate.Text;
            Oprema updateanaOprema = new Oprema(); 

            updateanaOprema.Id = idUpdate;
            updateanaOprema.Naziv = nazivUpdate;
            updateanaOprema.Vrsta = vrstaUpdate;
            updateanaOprema.DatVrPrimke = datVrPrimkeUpdate;
            updateanaOprema.NazivProjekta = nazivProjektaUpdate;
            updateanaOprema.IzvorFinanciranja = RepozitorijIzvoraFinanciranja.GetIzvorFinanciranja(cboIzvorFinanciranjaUpdate.SelectedIndex + 1); 
            updateanaOprema.OpisOpreme = opisOpremeUpdate;
            updateanaOprema.OsobaNabave = osobaNabaveUpdate;
            updateanaOprema.OsobaPrimke = osobaPrimkeUpdate;

            RepozitorijOpreme.UpdateOpreme(updateanaOprema);

            MessageBox.Show("Uspješan update!");

            FrmOprema frmOprema = new FrmOprema();
            Hide();
            frmOprema.ShowDialog();
            Close();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            string message = "Izbrisati ovaj red?";
            string title = "Potvrda";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int idUpdate = int.Parse(txtIdUpdate.Text);
                Oprema updateanaOprema = new Oprema();
                updateanaOprema.Id = idUpdate;
                RepozitorijOpreme.IzbrisiOpremu(updateanaOprema.Id);

                FrmOprema frmOprema = new FrmOprema();
                Hide();
                MessageBox.Show("Uspješno brisanje!");
                frmOprema.ShowDialog();
                Close();
            }   
        }
    }
}
