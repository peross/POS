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
    public partial class frmIzvjestaji : Form
    {
        public frmIzvjestaji()
        {
            InitializeComponent();
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

        private void btnPrikaziMjesecniIzvjestaj_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EFMEIMP;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("pregledProdajePoMjesecu", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@odDatuma", SqlDbType.Date).Value = dtpOd.Value.Date;
            cmd.Parameters.Add("@doDatuma", SqlDbType.Date).Value = dtpDo.Value.Date;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvIzjvestaj.DataSource = dt;
            con.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EFMEIMP;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("pregledProdajePoRadniku", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ImeRadnika", SqlDbType.NVarChar).Value = txtIme.Text.Trim();
            cmd.Parameters.Add("@PrezimeRadnika", SqlDbType.NVarChar).Value = txtPrezime.Text.Trim();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvIzjvestaj.DataSource = dt;
            con.Close();
        }

        private void btnPrikaziDnevniIzvjesaj_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EFMEIMP;Initial Catalog=Prodaja;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("ukupnaPotrosnjaPoDanu", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Datum", SqlDbType.Date).Value = dtpDan.Value.Date;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvIzjvestaj.DataSource = dt;
            con.Close();
        }
    }
}
