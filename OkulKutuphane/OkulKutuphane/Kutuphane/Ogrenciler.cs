using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulKutuphane.Kutuphane
{
    public class Ogrenciler
    {
        public int _ogrID { get; set; }
        public int _ogrNo { get; set; }
        public int _ogrSifre { get; set; }
        public Ogrenciler()
        {

        }

        public Ogrenciler(int ogrID, int ogrNo, int ogrSifre)
        {
            _ogrID = ogrID;
            _ogrNo = ogrNo;
            _ogrSifre = ogrSifre;
        }
    }
}
