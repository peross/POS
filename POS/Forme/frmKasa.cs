using DbFramework;
using POS.Klase;
using Resotran.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forme
{
    public partial class frmKasa : frmTema
    {
        public frmKasa()
        {
            InitializeComponent();
        }

        private void frmKasa_Load(object sender, EventArgs e)
        {
            txtBarkod.Focus();
            generisiNoviId();
            lblImeProdavca.Text = frmKontrolnaTabla.imeRadnika;
            lblPrezimeProdavca.Text = frmKontrolnaTabla.prezimeRadnika;
            popuniCmb();
            vratiIdRadnika();
        }
        private void generisiNoviId()
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());
            txtIdNarudzbe.Text = db.vratiSkalarnuVrijednost("korpaGenerisiNoviId").ToString();
        }
        private void vratiIdRadnika()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EFMEIMP;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT IdRadnika FROM Radnici WHERE Ime='" + lblImeProdavca.Text + "' AND Prezime='" + lblPrezimeProdavca.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblIdRadnika.Text = dr["IdRadnika"].ToString();
            }
            con.Close();

        }

        private void popuniCmb()
        {
            cmbArtikli.Items.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EFMEIMP;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Naziv, Cijena FROM Artikli";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbArtikli.Items.Add(dr["Naziv"].ToString());
            }
            con.Close();
        }

        private List<ArtikliKorpa> sopingKorpa = new List<ArtikliKorpa>();
        private int brStaviPoStrani = 0;
        private int brStavkiZaStampanje = 0;

        private void btnDodajUkorpu_Click(object sender, EventArgs e)
        {
            if (formaValidna())
            {
                if (txtBarkod.Text.Trim() == string.Empty || txtNazivArtikla.Text.Trim() == string.Empty || txtKolicina.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Niste pravilno popunili sva tražena polja (šifra, naziv artikla, količina)", "Greška", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    ArtikliKorpa stavke = new ArtikliKorpa()
                    {
                        IdArtikla = Convert.ToInt32(txtBarkod.Text.Trim()),
                        Artikli = txtNazivArtikla.Text,
                        Kolicina = Convert.ToDecimal(txtKolicina.Text.Trim()),
                        CijenaPoJedinici = Convert.ToDecimal(txtCijenaPoJedinici.Text.Trim()),
                        UkupanIznos = Convert.ToDecimal(txtKolicina.Text.Trim()) * Convert.ToDecimal(txtCijenaPoJedinici.Text.Trim())
                    };
                    txtSifraArtikla.Text = txtBarkod.Text;
                    txtKolicinaStavke.Text = txtKolicina.Text;

                    sopingKorpa.Add(stavke);
                    dgvPorudzba.DataSource = null;
                    dgvPorudzba.DataSource = sopingKorpa;


                    txtNazivArtikla.Clear();
                    txtKolicina.Text = "1";
                    txtCijenaPoJedinici.Clear();

                    decimal ukupanIznos = sopingKorpa.Sum(x => x.UkupanIznos);
                    decimal pdv = (17 * ukupanIznos) / 100;
                    decimal iznosBezPDV = (ukupanIznos - pdv);

                    txtUkupanIznos.Text = Math.Round(iznosBezPDV,2,MidpointRounding.ToEven).ToString();
                    txtPDV.Text = Math.Round(pdv,2,MidpointRounding.ToEven).ToString();
                    txtUkZaPlatiti.Text = Math.Round(ukupanIznos,2,MidpointRounding.ToEven).ToString(".00");

                    txtBarkod.Text = "";
                }
                
            }
        }
        private bool formaValidna()
        {
            int tempBarkod;
            bool jeBroj = int.TryParse(txtBarkod.Text, out tempBarkod);

            return true;
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            decimal tempBarkod;
            bool jeBroj = decimal.TryParse(txtBarkod.Text.Trim(), out tempBarkod);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EFMEIMP;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Naziv FROM Artikli WHERE IdProizvoda='" + txtBarkod.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtNazivArtikla.Text = dr["Naziv"].ToString();
            }
            con.Close();
        }

        private void txtNazivArtikla_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EFMEIMP;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT IdProizvoda,Cijena FROM Artikli WHERE Naziv='" + txtNazivArtikla.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtBarkod.Text = dr["IdProizvoda"].ToString();
                txtCijenaPoJedinici.Text = dr["Cijena"].ToString();
            }
            con.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("====================================",
                new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular), Brushes.Black, new Point(2, 20));
            e.Graphics.DrawString("РЕСТОРАН 100+", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
                Brushes.Black, new Point(78, 30));
            e.Graphics.DrawString("СИМЕ ШОЛАЈЕ 14", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
                Brushes.Black, new Point(72, 40));
            e.Graphics.DrawString("70 260 МРКОЊИЋ ГРАД", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(50, 50));
            e.Graphics.DrawString("------------------------------------", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, 60));
            e.Graphics.DrawString("МАЛОПРОДАЈНИ", new Font("HypermarketExpW00-Regular", 8, FontStyle.Bold),
               Brushes.Black, new Point(70, 70));
            e.Graphics.DrawString("ФИСКАЛНИ РАЧУН", new Font("HypermarketExpW00-Regular", 8, FontStyle.Bold),
               Brushes.Black, new Point(62, 80));
            e.Graphics.DrawString("------------------------------------", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, 90));

            int yPozicija = 105;
            for (int i = brStavkiZaStampanje; i < sopingKorpa.Count; i++)
            {
                brStaviPoStrani++;
                if (brStaviPoStrani <= 32)
                {
                    brStavkiZaStampanje++;
                    if (brStavkiZaStampanje <= sopingKorpa.Count)
                    {
                        e.Graphics.DrawString(sopingKorpa[i].Artikli, new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
            Brushes.Black, new Point(5, yPozicija));
                        e.Graphics.DrawString(sopingKorpa[i].Kolicina.ToString() + "x", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
                      Brushes.Black, new Point(20, yPozicija + 13));
                        e.Graphics.DrawString(sopingKorpa[i].CijenaPoJedinici.ToString(), new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
                      Brushes.Black, new Point(130, yPozicija + 13));
                        e.Graphics.DrawString(sopingKorpa[i].UkupanIznos.ToString(), new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
                      Brushes.Black, new Point(225, yPozicija + 13));
                        yPozicija += 25;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    brStaviPoStrani = 0;
                    e.HasMorePages = true;
                    return;
                }
            }

            e.Graphics.DrawString("------------------------------------", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 10));
            e.Graphics.DrawString("СЕ: 17,00%", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 20));
            e.Graphics.DrawString("ПЕ:", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 30));
            e.Graphics.DrawString(txtPDV.Text, new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(225, yPozicija + 30));
            e.Graphics.DrawString("ПУ:", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 40));
            e.Graphics.DrawString(txtPDV.Text, new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(225, yPozicija + 40));
            e.Graphics.DrawString("ЕЕ:", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 50));
            e.Graphics.DrawString(txtUkZaPlatiti.Text, new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(225, yPozicija + 50));
            e.Graphics.DrawString("ЕУ:", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 60));
            e.Graphics.DrawString(txtUkZaPlatiti.Text, new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(225, yPozicija + 60));
            e.Graphics.DrawString("ЕБ:", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 70));
            e.Graphics.DrawString(txtUkupanIznos.Text, new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(225, yPozicija + 70));
            e.Graphics.DrawString("------------------------------------", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 80));
            e.Graphics.DrawString("ЗА УПЛАТУ:", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 90));
            e.Graphics.DrawString(txtUkZaPlatiti.Text, new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(225, yPozicija + 90));
            e.Graphics.DrawString("ГОТОВИНА:", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 100));
            e.Graphics.DrawString(txtUkZaPlatiti.Text, new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(225, yPozicija + 100));
            e.Graphics.DrawString("УПЛАЋЕНО:", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 110));
            e.Graphics.DrawString(txtUkZaPlatiti.Text, new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(225, yPozicija + 110));
            e.Graphics.DrawString("ПОВРАТ: ", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 120));
            e.Graphics.DrawString("0,00", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(225, yPozicija + 120));
            e.Graphics.DrawString(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(), new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 130));
            e.Graphics.DrawString("БФ:  "+txtIdNarudzbe.Text, new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 150));
            e.Graphics.DrawString("___", new Font("HypermarketExpW00-Regular", 7, FontStyle.Regular),
               Brushes.Black, new Point(98, yPozicija + 136));
            e.Graphics.DrawString("|", new Font("HypermarketExpW00-Regular", 7, FontStyle.Regular),
               Brushes.Black, new Point(97, yPozicija + 145));
            e.Graphics.DrawString("|", new Font("HypermarketExpW00-Regular", 7, FontStyle.Regular),
               Brushes.Black, new Point(97, yPozicija + 154));
            e.Graphics.DrawString("П", new Font("HypermarketExpW00-Regular", 7, FontStyle.Regular),
               Brushes.Black, new Point(100, yPozicija + 145));
            e.Graphics.DrawString("У", new Font("HypermarketExpW00-Regular", 7, FontStyle.Regular),
               Brushes.Black, new Point(110, yPozicija + 145));
            e.Graphics.DrawString("Р", new Font("HypermarketExpW00-Regular", 7, FontStyle.Regular),
               Brushes.Black, new Point(100, yPozicija + 155));
            e.Graphics.DrawString("С", new Font("HypermarketExpW00-Regular", 7, FontStyle.Regular),
               Brushes.Black, new Point(110, yPozicija + 155));
            e.Graphics.DrawString("|", new Font("HypermarketExpW00-Regular", 7, FontStyle.Bold),
               Brushes.Black, new Point(106, yPozicija + 145));
            e.Graphics.DrawString("|", new Font("HypermarketExpW00-Regular", 7, FontStyle.Bold),
               Brushes.Black, new Point(106, yPozicija + 154));
            e.Graphics.DrawString("|", new Font("HypermarketExpW00-Regular", 7, FontStyle.Regular),
               Brushes.Black, new Point(116, yPozicija + 145));
            e.Graphics.DrawString("|", new Font("HypermarketExpW00-Regular", 7, FontStyle.Regular),
               Brushes.Black, new Point(116, yPozicija + 154));
            e.Graphics.DrawString("___", new Font("HypermarketExpW00-Regular", 7, FontStyle.Bold),
               Brushes.Black, new Point(98, yPozicija + 146));     
            e.Graphics.DrawString("___", new Font("HypermarketExpW00-Regular", 7, FontStyle.Regular),
               Brushes.Black, new Point(98, yPozicija + 156));
            e.Graphics.DrawString("====================================",
                new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular), Brushes.Black, new Point(2, yPozicija + 165));
            e.Graphics.DrawString("ХВАЛА НА ПОВЈЕРЕЊУ!",
                new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular), Brushes.Black, new Point(53, yPozicija + 175));
            e.Graphics.DrawString("------------------------------------", new Font("HypermarketExpW00-Regular", 8, FontStyle.Regular),
               Brushes.Black, new Point(2, yPozicija + 185));

            brStaviPoStrani = 0;
            brStavkiZaStampanje = 0;
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDodajUkorpu.PerformClick();
            txtBarkod.Focus();
        }

        private void btnPregledRacuna_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            snimiIliAzurirajZapis("korpaDodavanje");
            snimiIliAzurirajZapis("stavkeKorpeDodavanje");
        }
        private Korpa snimiIliAzurirajZapis(string storedProceIme)
        {
            Korpa korpa = new Korpa();
            return korpa;
        }

        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            int index = dgvPorudzba.CurrentCell.RowIndex;
            sopingKorpa.RemoveAt(index);
            dgvPorudzba.DataSource = null;
            dgvPorudzba.DataSource = sopingKorpa;

            decimal ukupanIznos = sopingKorpa.Sum(x => x.UkupanIznos);
            decimal pdv = (17 * ukupanIznos) / 100;
            decimal iznosBezPDV = ukupanIznos - pdv;

            txtUkupanIznos.Text = iznosBezPDV.ToString();
            txtPDV.Text = pdv.ToString();
            txtUkZaPlatiti.Text = ukupanIznos.ToString("0.00");
        }

        private void btnPonistiNarudzbu_Click(object sender, EventArgs e)
        {
            txtSifraArtikla.Clear();
            txtKolicina.Text = "1";
            txtNazivArtikla.Clear();
            txtCijenaPoJedinici.Clear();

            dgvPorudzba.DataSource = null;
            txtUkupanIznos.Text = "0";
            txtPDV.Text = "0";
            txtUkZaPlatiti.Text = "0.00";
            sopingKorpa.Clear();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnStampajRacun_Click(object sender, EventArgs e)
        {
            dodavanjeUkorpu("dodavanjeKorpa");
            dodavanjeStavkeKorpe();
            generisiNoviId();
            printDocument1.Print();
        }
        private void dodavanjeStavkeKorpe()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EFMEIMP;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();

            for (int i = 0; i < dgvPorudzba.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO StavkeKorpe(IdProizvoda, IdKorpe, Kolicina) VALUES(@idProizvoda, @idKorpe, @kolicina)", con);
                cmd.Parameters.AddWithValue("@idProizvoda", dgvPorudzba.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@idKorpe", Convert.ToInt32(txtIdNarudzbe.Text.Trim()));
                cmd.Parameters.AddWithValue("@kolicina", dgvPorudzba.Rows[i].Cells[2].Value);
                cmd.ExecuteNonQuery();
            }
        }
        private void dodavanjeUkorpu(string storedProceIme)
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());
            db.snimiIliAzurirajZapis(storedProceIme, vratiObjekt());
        }
        private Korpa vratiObjekt()
        {
            Korpa korpa = new Korpa();
            korpa.IdKorpe = Convert.ToInt32(txtIdNarudzbe.Text.Trim());
            korpa.IdRadnika = Convert.ToInt32(lblIdRadnika.Text.Trim());
            korpa.Datum = dtpDatum.Value.Date;
            return korpa;
        }

    }
}
