using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulKutuphane.DataBase_Folder
{
    public class DataBase
    {
        public static string GetConnectionString
        {
            get { return "Data Source=.\\SQLEXPRESS;Initial Catalog=vt_kutuphane;Integrated Security=True"; }
        }
    }
}
