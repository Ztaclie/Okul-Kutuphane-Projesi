using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OkulKutuphane.DataBase_Folder
{
    public class kitapDal
    {
        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        bool result;

        
        public bool Add(string kitapAdi, string kitapYazari, string kitapTuru, int kitapSayfa, int rafNum, int kitaplikNum)
        {
            sql = "INSERT INTO dbo.kitap_table (kitapAdi,kitapYazari,kitapTuru,kitapSayfa,rafNum,kitaplikNum) VALUES ('" + kitapAdi + "', '" + kitapYazari + "', '" + kitapTuru + "', '" + kitapSayfa + "', '" + rafNum + "', '" + kitaplikNum + "');";
            cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int sonuc = cmd.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public bool Update(int kitapID,string kitapAdi, string kitapYazari, string kitapTuru, int kitapSayfa, int rafNum, int kitaplikNum)
        {
            sql = "UPDATE dbo.kitap_table SET kitapAdi='" + kitapAdi + "',kitapYazari='" + kitapYazari + "',kitapTuru='" + kitapTuru + "',kitapSayfa='" + kitapSayfa + "',rafNum='" + rafNum + "',kitaplikNum='" + kitaplikNum + "' WHERE kitapID=" + kitapID;
            cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int sonuc = cmd.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    result = true;
                }
            }
            catch
            {

                throw;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }
    }
}
