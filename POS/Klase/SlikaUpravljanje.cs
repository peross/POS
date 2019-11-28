using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Klase
{
    public class SlikaUpravljanje
    {
        //byte[]
        public static byte[] vratiSliku(PictureBox pcb)
        {
            MemoryStream ms = new MemoryStream();
            pcb.Image.Save(ms, pcb.Image.RawFormat);
            return ms.GetBuffer();
        }

        public static Image staviSliku(byte[] slika)
        {
            MemoryStream ms = new MemoryStream(slika);
            return Image.FromStream(ms);
        }

    }
}
