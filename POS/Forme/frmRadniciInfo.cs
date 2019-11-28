using DbFramework;
using POS.Klase;
using Resotran.Klase;
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
    public partial class frmRadniciInfo : frmTema
    {
        public frmRadniciInfo()
        {
            InitializeComponent();
        }
        public int radnikId { get; set; }

        private void frmRadniciInfo_Load(object sender, EventArgs e)
        {
            txtSifra.UseSystemPasswordChar = true;

            ucitajPodatkeUcmb();
            cmbUloga.SelectedIndex = -1;
            if (this.JeAzuriran)
            {
                //ucitavanje podataka u formu nakon dvostrukog klika na zeljenog radnika u dgv
                ucitajPodatke();
                ukljuciDugmad();
            }
            else
            {
                generisiNoviId();
            }

            if (txtIme.Text.Trim() == string.Empty && txtPrezime.Text.Trim() == string.Empty)
            {
                lblRadnikPanel.Text = "Radnik";
            }
            else
            {
                lblRadnikPanel.Text = txtIme.Text + " " + txtPrezime.Text;
            }
        }
        private void ucitajPodatke()
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());
            DataTable dtRadnici = db.vratiPodatkeLista("vratiRadnikaNaOsnouvIdRadnika", new DbParametri
            { Parametar = "@IdRadnika", Vrijednost = this.radnikId });
            DataRow red = dtRadnici.Rows[0];

            txtRadnikID.Text = red["IdRadnika"].ToString();

            txtIme.Text = red["Ime"].ToString();
            txtPrezime.Text = red["Prezime"].ToString();
            dtpDatumRodjenja.Value = Convert.ToDateTime(red["Datum rođenja"]);

            txtKorIme.Text = red["Korisničko ime"].ToString();
            txtSifra.Text = red["Šifra"].ToString();
            txtTelefon.Text = red["Telefon"].ToString();

            txtAdresa.Text = red["Adresa"].ToString();
            txtTrenutnaPlata.Text = red["Trenutna plata"].ToString();
            txtPocetnaPlata.Text = red["Početna plata"].ToString();
            cmbUloga.SelectedValue = red["IdUloge"];

            pcbSlika.Image = (red["Slika"] is DBNull) ? null : SlikaUpravljanje.staviSliku((byte[])red["Slika"]);

            if (pcbSlika.Image == null)
                pcbSlika.BackgroundImage = POS.Properties.Resources.no_photo;
        }

        private void ucitajPodatkeUcmb()
        {
            using (ProdajaEntities1 db = new ProdajaEntities1())
            {
                cmbUloga.DataSource = db.Uloge.ToList();
                cmbUloga.DisplayMember = "Naziv";
                cmbUloga.ValueMember = "IdUloge";
            }
        }
        private void generisiNoviId()
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());
            txtRadnikID.Text = db.vratiSkalarnuVrijednost("radniciGenerisiNoviId").ToString();
        }
        private void postaviSliku()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Izaberite sliku";
            ofd.Filter = "Slika (*.png; *.jpg; *.bmp; *.gif)| *.png; *.jpg; *.bmp; *.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
                pcbSlika.Image = new Bitmap(ofd.FileName);
        }
        private void ukljuciDugmad()
        {
            dodajToolStripMenuItem.Enabled = true;
            posaljiToolStripMenuItem.Enabled = true;
            stampajToolStripMenuItem.Enabled = true;
        }
        private void snimiIliAzurirajZapis(string storedProceIme)
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());
            db.snimiIliAzurirajZapis(storedProceIme, vratiObjekt());
        }
        // DODAVANJE NOVIH RADNIKA
        private zaposleniRadnici vratiObjekt()
        {
            zaposleniRadnici radnik = new zaposleniRadnici();
            radnik.IdRadnika = Convert.ToInt32(txtRadnikID.Text);
            radnik.Ime = txtIme.Text.Trim();
            radnik.Prezime = txtPrezime.Text.Trim();
            radnik.Telefon = txtTelefon.Text.Trim();
            radnik.Sifra = txtSifra.Text.Trim();
            radnik.KorIme = txtKorIme.Text.Trim();
            radnik.AdresaStanovanja = txtAdresa.Text.Trim();

            radnik.IdUloge = Convert.ToInt32(cmbUloga.SelectedValue);
            radnik.TrenutnaPlata = Convert.ToDecimal(txtTrenutnaPlata.Text);
            radnik.PocetnaPlata = Convert.ToDecimal(txtPocetnaPlata.Text);

            radnik.DatumRodjenja = dtpDatumRodjenja.Value.Date;
            radnik.KreiranDana = dtpDatumKreiranja.Value.Date;

            radnik.Komentar = txtKomentar.Text.Trim();
            // radnik.Grad = txtGrad.Text.Trim();

            radnik.Slika = (pcbSlika.Image == null) ? null : SlikaUpravljanje.vratiSliku(pcbSlika);
            return radnik;
        }

        private bool formaValidna()
        {
            if (txtIme.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti ime.");
                txtIme.Focus();
                return false;
            }
            if (txtPrezime.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti prezime.");
                txtPrezime.Focus();
                return false;
            }
            if (txtKorIme.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti korisničko ime.");
                txtKorIme.Focus();
                return false;
            }
            if (txtSifra.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti šifru.");
                txtSifra.Focus();
                return false;
            }
            if (cmbUloga.SelectedIndex == -1)
            {
                Obavjestenja.prikaziPorukuGreska("Morate izabrati ulogu.");
                cmbUloga.Focus();
                return false;
            }
            if (txtTrenutnaPlata.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti trenutnu platu.");
                txtTrenutnaPlata.Focus();
                return false;
            }
            if (txtPocetnaPlata.Text.Trim() == string.Empty)
            {
                Obavjestenja.prikaziPorukuGreska("Morate unijeti početnu platu.");
                txtPocetnaPlata.Focus();
                return false;
            }
            return true;
        }

        private void snimiZapisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formaValidna())
            {
                if (this.JeAzuriran)
                {
                    snimiIliAzurirajZapis("azurirajRadnika");
                    Obavjestenja.prikaziPorukuUspjesno("Podaci su uspjesno azurirani.");

                    this.JeAzuriran = true;
                    ukljuciDugmad();
                }

                else
                {
                    snimiIliAzurirajZapis("dodavanjeRadnika");
                    Obavjestenja.prikaziPorukuUspjesno("Podaci su ubaceni.");
                }
                this.Close();
            }
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            postaviSliku();
        }

        private void btnObrisiSliku_Click(object sender, EventArgs e)
        {
            pcbSlika.Image = POS.Properties.Resources.no_photo;
        }

        private void btnPrikaziSifru_Click(object sender, EventArgs e)
        {
            if (txtSifra.UseSystemPasswordChar == true)
                txtSifra.UseSystemPasswordChar = false;
            else
                txtSifra.UseSystemPasswordChar = true;
        }
    }
}
