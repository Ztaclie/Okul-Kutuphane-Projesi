using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulKutuphane.DataBase_Folder
{
    public class emanetDal
    {
        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        bool result;

        public bool Add(int ogrNo, string kitapVerTarih, string kitapAlnmTarih, int kitapID, string kitapAdi)
        {
            sql = "INSERT INTO dbo.emanet_table (ogrNo,kitapVerTarih,kitapAlnmTarih,kitapID,kitapAdi) VALUES ('" + ogrNo + "', '" + kitapVerTarih + "', '" + kitapAlnmTarih + "', '" + kitapID + "', '" + kitapAdi + "');";
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

        public bool Update(int emanetID, int ogrNo, string kitapVerTarih, string kitapAlnmTarih, int kitapID, string kitapAdi)
        {
            sql = "UPDATE dbo.emanet_table SET ogrNo='" + ogrNo + "',kitapVerTarih='" + kitapVerTarih + "',kitapAlnmTarih='" + kitapAlnmTarih + "',kitapID='" + kitapID + "',kitapAdi='" + kitapAdi + "' WHERE emanetID=" + emanetID;
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
