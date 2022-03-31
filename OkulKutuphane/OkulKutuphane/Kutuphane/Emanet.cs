using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulKutuphane.Kutuphane
{
    public class Emanet
    {
        public int _emanetID { get; set; }
        public int _ogrNo { get; set; }
        public string _kitapVerTarih { get; set; }
        public string _kitapAlmTarih { get; set; }
        public int _kitapID { get; set; }
        public string _kitapAdi { get; set; }

        public Emanet()
        {

        }

        public Emanet(int emanetID, int ogrNo, string kitapVerTarih, string kitapAlmTarih, int kitapID, string kitapAdi)
        {
            this._emanetID = emanetID;
            this._ogrNo = ogrNo;
            this._kitapVerTarih = kitapVerTarih;
            this._kitapAlmTarih = kitapAlmTarih;
            this._kitapID = kitapID;
            this._kitapAdi = kitapAdi;
        }

    }
}
