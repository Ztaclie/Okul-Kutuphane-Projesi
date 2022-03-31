using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulKutuphane.Kutuphane
{
    public class Idare
    {
        public int _idareID { get; set; }
        public int _idareNo { get; set; }
        public int _idareSifre { get; set; }
        public Idare()
        {

        }

        public Idare(int idareID, int idareNo, int idareSifre)
        {
            _idareID = idareID;
            _idareNo = idareNo;
            _idareSifre = idareSifre;
        }
    }
}
