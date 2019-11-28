using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Klase
{
    public class Obavjestenja
    {
        public static void prikaziPorukuGreska(string poruka)
        {
            MessageBox.Show(poruka, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void prikaziPorukuGreska(string poruka, string naslov)
        {
            MessageBox.Show(poruka, naslov, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void prikaziPorukuUspjesno(string poruka)
        {
            MessageBox.Show(poruka, "Obavještenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void prikaziPorukuUspjesno(string poruka, string naslov)
        {
            MessageBox.Show(poruka, naslov, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
