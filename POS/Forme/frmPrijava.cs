using DbFramework;
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
    public partial class frmPrijava : frmTema
    {
        public static string postaviIme = "";
        public static string postaviSifru = "";

        public frmPrijava()
        {
            InitializeComponent();

            #region Brisanje pozadine
            lblVrijeme.Parent = pictureBox1;
            lblVrijeme.BackColor = Color.Transparent;
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.FromArgb(180,0,0,0);

            panel1.Location = new Point(this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
            btnIzlaz.Parent = pictureBox1;
            btnIzlaz.BackColor = Color.Transparent;
            #endregion
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToLongTimeString() + "\r\n" + DateTime.Now.ToLongDateString();
        }

        private void tDatumVrijeme_Tick(object sender, EventArgs e)
        {
            tDatumVrijeme.Start();
            lblVrijeme.Text = DateTime.Now.ToLongTimeString() + "\r\n" + DateTime.Now.ToLongDateString();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            postaviIme = txtKorIme.Text;
            postaviSifru = txtSifra.Text;
            if (formaValidna())
            {
                DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());

                bool detaljiPrijaveTacni = Convert.ToBoolean(db.vratiSkalarnuVrijednost("provjeraPrijave",
                    vratiParametre()));
                if (detaljiPrijaveTacni)
                {
                    this.Hide();
                    frmKontrolnaTabla forma = new frmKontrolnaTabla();
                    forma.Show();
                }
                else
                {
                    MessageBox.Show("Netačno korisničko ime ili šifra.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        
        private DbParametri[] vratiParametre()
        {
            List<DbParametri> parametri = new List<DbParametri>();
            DbParametri dbParam1 = new DbParametri();
            dbParam1.Parametar = "@KorIme";
            dbParam1.Vrijednost = txtKorIme.Text;
            parametri.Add(dbParam1);

            DbParametri dbParam2 = new DbParametri();
            dbParam2.Parametar = "@Sifra";
            dbParam2.Vrijednost = txtSifra.Text;
            parametri.Add(dbParam2);

            return parametri.ToArray();
        }
        private bool formaValidna()
        {
            if (txtKorIme.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Morate unijeti korisničko ime.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKorIme.ResetText();
                txtKorIme.Focus();
                return false;
            }

            if (txtSifra.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Morate unijeti šifru.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifra.ResetText();
                txtSifra.Focus();
                return false;
            }
            return true;
        }

        private void txtSifra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPrijava.PerformClick();
        }
    }
}
