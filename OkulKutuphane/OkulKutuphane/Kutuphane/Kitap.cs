using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulKutuphane.Kutuphane
{
    public class Kitap
    {
        public int _kitapID { get; set; }
        public string _kitapAdi { get; set; }
        public string  _kitapYazari { get; set; }
        public string _kitapTuru { get; set; }
        public int _kitapSayfa { get; set; }
        public string _rafNum { get; set; }
        public string _kitaplikNum { get; set; }

        public Kitap()
        {

        }
        public Kitap(int kitapID, string kitapAdi, string kitapYazari, string kitapTuru, int kitapSayfa, string rafNum, string kitaplikNum)
        {
            _kitapID = kitapID;
            _kitapAdi = kitapAdi;
            _kitapYazari = kitapYazari;
            _kitapTuru = kitapTuru;
            _kitapSayfa = kitapSayfa;
            _rafNum = rafNum;
            _kitaplikNum = kitaplikNum;
        }


    }
}
