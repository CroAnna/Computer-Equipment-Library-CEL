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
using System.Data.SqlClient;

namespace CELnovi
{
    public partial class FrmOprema : Form
    {
        public FrmOprema()
        {
            InitializeComponent();
        }
        
        private void FrmOprema_Load(object sender, EventArgs e)
        {
            PrikaziOpremu();
            txtSearch.Text = "Pretrazi opremu prema nazivu...";
        }

        private void PrikaziOpremu()
        {
            var opreme = RepozitorijOpreme.GetOpremas();
            dgvOprema.DataSource = opreme;

            dgvOprema.Columns["Id"].DisplayIndex = 0;
            dgvOprema.Columns["Naziv"].DisplayIndex = 1;
            dgvOprema.Columns["Vrsta"].DisplayIndex = 2;
            dgvOprema.Columns["DatVrPrimke"].DisplayIndex = 3;
            dgvOprema.Columns["NazivProjekta"].DisplayIndex = 4;
            dgvOprema.Columns["IzvorFinanciranja"].DisplayIndex = 5;
            dgvOprema.Columns["OpisOpreme"].DisplayIndex = 6;
            dgvOprema.Columns["OsobaNabave"].DisplayIndex = 7;
            dgvOprema.Columns["OsobaPrimke"].DisplayIndex = 8;

        }
        
        private void btnUnesi2Click(object sender, EventArgs e)
        {
            Oprema odabranaOprema = dgvOprema.CurrentRow.DataBoundItem as Oprema; 
            if (odabranaOprema != null)
            {
                FrmUnosOpreme frmUnosOpreme = new FrmUnosOpreme(odabranaOprema);
                Hide();
                frmUnosOpreme.ShowDialog();
                Close();
            }
        }

        private void bntUrediClick(object sender, EventArgs e) 
        {
            Oprema odabranaOprema = dgvOprema.CurrentRow.DataBoundItem as Oprema;
            if (odabranaOprema != null) 
            {
                FrmUpdate frmUpdate = new FrmUpdate(odabranaOprema);
                Hide();
                frmUpdate.ShowDialog();
                Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "") // ak nije prazno
            {
                var opreme = RepozitorijOpreme.GetOpremasSearch(txtSearch.Text);
                dgvOprema.DataSource = opreme;

                dgvOprema.Columns["Id"].DisplayIndex = 0;
                dgvOprema.Columns["Naziv"].DisplayIndex = 1;
                dgvOprema.Columns["Vrsta"].DisplayIndex = 2;
                dgvOprema.Columns["DatVrPrimke"].DisplayIndex = 3;
                dgvOprema.Columns["NazivProjekta"].DisplayIndex = 4;
                dgvOprema.Columns["IzvorFinanciranja"].DisplayIndex = 5;
                dgvOprema.Columns["OpisOpreme"].DisplayIndex = 6;
                dgvOprema.Columns["OsobaNabave"].DisplayIndex = 7;
                dgvOprema.Columns["OsobaPrimke"].DisplayIndex = 8;
            }
            else
            {
                PrikaziOpremu();
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmOprema frmOprema = new FrmOprema(); 
            Hide();
            frmOprema.ShowDialog();
            Close();
        }
    }
}
