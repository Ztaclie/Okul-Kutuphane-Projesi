using OkulKutuphane.DataBase_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulKutuphane.Forms
{
    public partial class IdareKitapAra_WithYazar : Form
    {
        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        public IdareKitapAra_WithYazar()
        {
            InitializeComponent();
        }

        private void kayitGetir()
        {
            conn.Close();
            conn.Open();
            string kayit = "SELECT * from dbo.kitap_table";
            cmd = new SqlCommand(kayit, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        void yazarGetir()
        {
            List<string> readers = new List<string>();

            conn.Close();
            conn.Open();
            string kayit = "SELECT kitapYazari from dbo.kitap_table";
            cmd = new SqlCommand(kayit, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                readers.Add(dr["kitapYazari"].ToString());
            }


            foreach (string item in readers)
            {
                KitapAramaComboBox.Items.Add(item);
            }

            conn.Close();
        }

        private void AraButton_Click(object sender, EventArgs e)
        {
            conn.Close();
            string a = KitapAramaComboBox.Text;
            conn.Open();
            string kayit = "SELECT * from dbo.kitap_table WHERE kitapYazari LIKE '%" + a + "%';";
            cmd = new SqlCommand(kayit, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void YenileButton_Click(object sender, EventArgs e)
        {
            kayitGetir();
            KitapAramaComboBox.SelectedIndex = -1;
        }

        private void IdareKitapAra_WithYazar_Load(object sender, EventArgs e)
        {
            kayitGetir();
            yazarGetir();
        }
    }
}
