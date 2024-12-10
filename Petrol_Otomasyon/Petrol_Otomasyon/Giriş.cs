using Petrol_Otomasyon;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PETROL_OTOMASYON_8_ARALIIK
{
    public partial class Giriş : Form
    {
        public static string genel_bilgi = "";

        SqlConnection bağlantı = new SqlConnection(@"Data Source=FURKANN\SQLEXPRESS;Initial Catalog=petrol_otomasyon;Integrated Security=True;");
        public Giriş()
        {
            InitializeComponent();
        }

        private void pERSONELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kul = "Furkan";
            string şifre = "a";
            try
            {
                bağlantı.Open();
                string sorgu = "SELECT * FROM login WHERE kullaniciAdi=@kul AND şifre=@şifre";
                SqlCommand command = new SqlCommand(sorgu, bağlantı);
                command.Parameters.AddWithValue("@kul", kul);
                command.Parameters.AddWithValue("@şifre", şifre);
                SqlDataReader oku = command.ExecuteReader();



                if (oku.Read())
                {
                    genel_bilgi = "Hoşgeldin" + oku["kullaniciAdi"].ToString();
                    MessageBox.Show(genel_bilgi);
                    Sube Subeform = new Sube();
                    Subeform.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("hata");
            }
            finally
            {
                if (bağlantı.State == System.Data.ConnectionState.Open)
                {
                    bağlantı.Close();


                }
            }
        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}