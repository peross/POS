using DbFramework;
using Resotran.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forme
{
    public partial class frmKontrolnaTabla : Form
    {
        public static string imeRadnika = "";
        public static string prezimeRadnika = "";
        public frmKontrolnaTabla()
        {
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();

            pictureBox1.Location = new Point(this.ClientSize.Width / 2 - pictureBox1.Size.Width / 2,
                this.ClientSize.Height / 2 - pictureBox1.Size.Height / 2);
            pictureBox1.Anchor = AnchorStyles.None;
            toolStrip1.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKontrolnaTabla_Load(object sender, EventArgs e)
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());

            DataTable dtArikli = db.vratiPodatkeLista("infoKorisnik", new DbParametri
            {
                Parametar = "@KorIme",
                Vrijednost = frmPrijava.postaviIme
            });
            DataRow red = dtArikli.Rows[0];

            lblImeRadnika.Text = red["Ime"].ToString() + " " + red["Prezime"].ToString();
            imeRadnika = red["Ime"].ToString();
            prezimeRadnika = red["Prezime"].ToString();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            frmKasa forma = new frmKasa();
            forma.Show();
        }

        private void frmKontrolnaTabla_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrijava forma = new frmPrijava();
            forma.Show();
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            frmArtikli forma = new frmArtikli();
            forma.Show();
        }

        private void btnRadnici_Click(object sender, EventArgs e)
        {
            frmRadnici forma = new frmRadnici();
            forma.Show();
        }

        private void btnIzjvestaj_Click(object sender, EventArgs e)
        {
            frmIzvjestaji forma = new frmIzvjestaji();
            forma.Show();
        }
    }
}
