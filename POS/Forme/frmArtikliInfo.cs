using DbFramework;
using POS.Klase;
using Resotran.Klase;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POS.Forme
{
    public partial class frmArtikliInfo : Form
    {
        public frmArtikliInfo()
        {
            InitializeComponent();
        }
        public int artiklID { get; set; }
        public bool JeAzuriran { get; set; }

        private void frmArtikliInfo_Load(object sender, EventArgs e)
        {
            cmbJedMjere.SelectedIndex = -1;
            cmbKategorije.SelectedIndex = -1;
            ucitajPodatkeUcmb();
            ucitajPodatkeUcmbKategorije();
            if (this.JeAzuriran)
            {
                ucitajPodatake();
            }
            else
            {
                generisiNoviId();
            }
        }
        private void generisiNoviId()
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());
            txtIdProizvoda.Text = db.vratiSkalarnuVrijednost("proizvodiGenerisiNoviId").ToString();
        }

        private void ucitajPodatkeUcmb()
        {
            using (ProdajaEntities1 db = new ProdajaEntities1())
            {
                cmbJedMjere.DataSource = db.JedinicaMjere.ToList();
                cmbJedMjere.DisplayMember = "Naziv";
                cmbJedMjere.ValueMember = "SifJM";
            }
        }

        private void ucitajPodatkeUcmbKategorije()
        {
            using (ProdajaEntities1 db = new ProdajaEntities1())
            {
                cmbKategorije.DataSource = db.Kategorije.ToList();
                cmbKategorije.DisplayMember = "NazivKategorije";
                cmbKategorije.ValueMember = "IdKategorije";
            }
        }
        //ucitavanje podataka iz dgv-a u formu nakon dvostrukog klika
        private void ucitajPodatake()
        {
            if (this.JeAzuriran)
            {
                DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());

                DataTable dtArikli = db.vratiPodatkeLista("vratiDetaljeArtiklaNaOsnovuIdProizvoda", new DbParametri
                {
                    Parametar = "@IdProizvoda",
                    Vrijednost = this.artiklID
                });
                DataRow red = dtArikli.Rows[0];
                txtIdProizvoda.Text = red["IdProizvoda"].ToString();
                txtNazivArtikla.Text = red["Naziv"].ToString();
                txtCijena.Text = red["Cijena"].ToString();
                txtOpis.Text = red["Opis"].ToString();
                cmbJedMjere.SelectedValue = red["SifJM"];
                cmbKategorije.SelectedValue = red["IdKategorije"];

                pcbLogo.Image = (red["Slika"] is DBNull) ? null : SlikaUpravljanje.staviSliku((byte[])red["Slika"]);
            }
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void snimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formaValidna())
            {
                if (this.JeAzuriran)
                {
                    snimiIliAzurirajZapis("proizvodiAzuriraj");
                    Obavjestenja.prikaziPorukuUspjesno("Podaci su uspjesno azurirani.");
                }
                else
                {
                    snimiIliAzurirajZapis("proizvodiDodavanjeNovog");
                    Obavjestenja.prikaziPorukuUspjesno("Podaci su ubaceni.");
                }
                this.Close();
            }
        }

        private void snimiIliAzurirajZapis(string storedProceIme)
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());
            db.snimiIliAzurirajZapis(storedProceIme, vratiObjekt());
        }

        private Artikl vratiObjekt()
        {
            Artikl artikl = new Artikl();
            artikl.IdProizvoda = (this.JeAzuriran) ? this.artiklID : 0;
            artikl.IdProizvoda = Convert.ToInt32(txtIdProizvoda.Text);
            artikl.Naziv = txtNazivArtikla.Text;
            artikl.IdKategorije = Convert.ToInt32(cmbKategorije.SelectedValue);
            artikl.SifJM = Convert.ToInt32(cmbJedMjere.SelectedValue);
            artikl.Cijena = Convert.ToDecimal(txtCijena.Text);
            artikl.Opis = txtOpis.Text;

            artikl.Slika = (pcbLogo.Image == null) ? null : SlikaUpravljanje.vratiSliku(pcbLogo);
            return artikl;
        }

        private bool formaValidna()
        {
            if (txtNazivArtikla.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti naziv artikla.");
                txtNazivArtikla.Focus();
                return false;
            }
            if (txtCijena.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti cijenu artikla.");
                txtCijena.Focus();
                return false;
            }
            return true;
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Izaberite sliku";
            ofd.Filter = "Slika (*.png; *.jpg; *.bmp; *.gif)| *.png; *.jpg; *.bmp; *.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
                pcbLogo.Image = new Bitmap(ofd.FileName);
        }

        private void btnObrisiSliku_Click(object sender, EventArgs e)
        {
            pcbLogo.Image = POS.Properties.Resources.no_photo;
        }

        private void txtNazivArtikla_TextChanged(object sender, EventArgs e)
        {
            GornjiPanelLabel.Text = txtNazivArtikla.Text;
        }
    }
}
