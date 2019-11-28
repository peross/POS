using DbFramework;
using Resotran.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Klase
{
    public class ListePodaci
    {
        //ucitavanje podataka u dgv pri ucitavanju forme
        public static void ucitajPodatkeUdgv(DataGridView dgv, string storedProceIme)
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());
            dgv.DataSource = db.vratiPodatkeLista(storedProceIme);
        }

        //ucitavanje podataka u combo box pri ucitavanju forme
        public static void ucitajPodatkeUcmb(ComboBox cmb, DbParametri parametar)
        {
            DbSqlServer db = new DbSqlServer(AppOpcije.konekcioniString());
            cmb.DataSource = db.vratiPodatkeLista("vratiListeNaOsnovuId", parametar);
            cmb.DisplayMember = "Naziv";
            cmb.ValueMember = "SifJM";

            cmb.SelectedIndex = -1;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
