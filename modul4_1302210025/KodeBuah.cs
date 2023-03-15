using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210025
{
    internal class KodeBuah
    {
        public enum buah { apel,aprikot,alpukat,pisang,paprika,blackbarry,ceri,kelapa, jagung }
        String[] arr = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };

        public string getKodeBuah(buah namabuah) => arr[(int) namabuah];
    }
}
