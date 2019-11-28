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
    public partial class frmArtikli : frmTema
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EFMEIMP;Initial Catalog=Prodaja;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public frmArtikli()
        {
            InitializeComponent();       
        }
        public bool JeAzuriran { get; set; }

        private void prikaziArtikliInfo(int artiklId, bool jeAzuriran)
        {
            frmArtikliInfo forma = new frmArtikliInfo();
            forma.artiklID = artiklId;
            forma.JeAzuriran = jeAzuriran;
            forma.ShowDialog();
            ucitajPodatkeUdgv();
        }

        private void frmArtikli_Load(object sender, EventArgs e)
        {
            ucitajPodatkeUdgv();
        }
        private void ucitajPodatkeUdgv()
        {
            ListePodaci.ucitajPodatkeUdgv(dgvArtikliInfo, "vratiArtikle");
        }

        private void dodajNoviArtiklToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prikaziArtikliInfo(0, false);
        }

        private void dgvArtikliInfo_DoubleClick(object sender, EventArgs e)
        {
            int redIneks = dgvArtikliInfo.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int artiklId = Convert.ToInt32(dgvArtikliInfo.Rows[redIneks].Cells["Id"].Value);
            prikaziArtikliInfo(artiklId, true);
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSokovi_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 1", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnVino_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 2", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnPivo_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 3", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnZestokaPica_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 4", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnPredjela_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 5", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnSupeCorbe_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 6", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnRiba_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 7", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnPiletina_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 8", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnCuretina_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 9", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnSvinjetina_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 10", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnJunetina_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 11", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnPohovana_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 12", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnMeskicka_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 13", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnPrilozi_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 14", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnSalate_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 15", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 16", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnPizzaSpecial_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 17", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 18", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnLazanje_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 19", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnPoslastice_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT IdProizvoda AS 'Id', Naziv, Cijena FROM Proizvodi WHERE IdKategorije = 20", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvArtikliInfo.DataSource = dt;
            con.Close();
        }

        private void btnSveKategorije_Click(object sender, EventArgs e)
        {
            ucitajPodatkeUdgv();
        }
    }
}
