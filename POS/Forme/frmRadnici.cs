using POS.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forme
{
    public partial class frmRadnici : Form
    {
        public frmRadnici()
        {
            InitializeComponent();
        }

        private void dodajNovogRadnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prikaziFormuRadniciInfo(0, false);
        }
        private void prikaziFormuRadniciInfo(int RadnikId, bool jeAzuriran)
        {
            frmRadniciInfo forma = new frmRadniciInfo();
            forma.radnikId = RadnikId;
            forma.JeAzuriran = jeAzuriran;
            forma.ShowDialog();
        }

        private void frmRadnici_Load(object sender, EventArgs e)
        {
            ucitajPodatkeUdgv();
        }

        private void ucitajPodatkeUdgv()
        {
            ListePodaci.ucitajPodatkeUdgv(dgvRadniciInfo, "prikaziRadnike");
        }

        private void dgvRadniciInfo_DoubleClick(object sender, EventArgs e)
        {
            int redIndex = dgvRadniciInfo.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int radnikId = Convert.ToInt32(dgvRadniciInfo.Rows[redIndex].Cells["Id Radnika"].Value);
            prikaziFormuRadniciInfo(radnikId, true);
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
