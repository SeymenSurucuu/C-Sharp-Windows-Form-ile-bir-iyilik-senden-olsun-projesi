using gorselprogramlamaproje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlamaproje
{
    public partial class giris : Form
    {

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public giris()
        {
            InitializeComponent();
        }
        public class veri{
            public static String idsi, ad, sifre, kullanici, cinsiyet, bagiskurumu1, bagiskurumu2, bagiskurumu3;
            public static int bakiyesi,gizlimi1,gizlimi2,gizlimi3;
            public static int losev;
            public static int darrusafaka;
            public static int gaziler;
            public static int fatura;
            public static int adminmi;
            
        }
        static string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True";

        public static void veridegis1(string bilgi1, string bilgi2 )
        {
            SqlConnection connect = new SqlConnection(conString);

            try
            {
                connect.Open();
                string Sql = "UPDATE kullanicibilgileri SET " + bilgi1 + " = @degis WHERE id =" + veri.idsi ;
                SqlCommand komut = new SqlCommand(Sql, connect);
                komut.Parameters.AddWithValue("@degis", bilgi2);
                komut.ExecuteNonQuery();
                connect.Close();
               
            }
            catch (Exception hata) { MessageBox.Show("Hata! " + hata.Message); }
        }
        public static void veridegis2(string bilgi1, int bilgi2)
        {
            SqlConnection connect = new SqlConnection(conString);

            try
            {
                connect.Open();
                string Sql = "UPDATE kullanicibilgileri SET " + bilgi1 + " = @degis WHERE id =" + veri.idsi;
                SqlCommand komut = new SqlCommand(Sql, connect);
                komut.Parameters.AddWithValue("@degis", bilgi2);
                komut.ExecuteNonQuery();
                connect.Close();
               
            }
            catch (Exception hata) { MessageBox.Show("Hata! " + hata.Message); }
            
        }
        public static void veridegis3(string bilgi1, int bilgi2,int bilgi3)
        {
            SqlConnection connect = new SqlConnection(conString);

            try
            {
                connect.Open();
                string Sql = "UPDATE kullanicibilgileri SET " + bilgi1 + " = @degis WHERE id = @degis3" ;
                SqlCommand komut = new SqlCommand(Sql, connect);
                komut.Parameters.AddWithValue("@degis", bilgi2);
                komut.Parameters.AddWithValue("@degis3", bilgi3);
                komut.ExecuteNonQuery();
                connect.Close();

            }
            catch (Exception hata) { MessageBox.Show("Hata! " + hata.Message); }

        }
        public static void veridegis4(string bilgi1, string bilgi2)
        {
            SqlConnection connect = new SqlConnection(conString);

            try
            {
                connect.Open();
                string Sql = "UPDATE bagiskurumlari SET " + bilgi1 + " = @degis";
                SqlCommand komut = new SqlCommand(Sql, connect);
                komut.Parameters.AddWithValue("@degis", bilgi2);
           
                komut.ExecuteNonQuery();
                connect.Close();

            }
            catch (Exception hata) { MessageBox.Show("Hata! " + hata.Message); }

        }
        public static void veridegis5(string bilgi1, int bilgi2)
        {
            SqlConnection connect = new SqlConnection(conString);

            try
            {
                connect.Open();
                string Sql = "UPDATE bagiskurumlari SET " + bilgi1 + " = @degis";
                SqlCommand komut = new SqlCommand(Sql, connect);
                komut.Parameters.AddWithValue("@degis", bilgi2);

                komut.ExecuteNonQuery();
                connect.Close();

            }
            catch (Exception hata) { MessageBox.Show("Hata! " + hata.Message); }

        }


        public static void veridegis6(string bilgi1, int bilgi2, int bilgi3)
        {
            SqlConnection connect = new SqlConnection(conString);

            try
            {
                connect.Open();
                string Sql = "UPDATE kullanicibilgileri SET " + bilgi1 + " = @degis WHERE id = @degis2";
                SqlCommand komut = new SqlCommand(Sql, connect);
                komut.Parameters.AddWithValue("@degis", bilgi2);
                komut.Parameters.AddWithValue("@degis2", bilgi3);

                komut.ExecuteNonQuery();
                connect.Close();

            }
            catch (Exception hata) { MessageBox.Show("Hata! " + hata.Message); }

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                String user = user1.Text;
                String password = pass.Text;
                
                con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "Select * From kullanicibilgileri where kullaniciadi ='" + user + "' and sifre ='" + password + "'";
                dr = com.ExecuteReader();
                
                if (dr.Read())
                {

                    veri.ad = dr["adsoyad"].ToString();
                    veri.kullanici = dr["kullaniciadi"].ToString();
                    veri.sifre = dr["sifre"].ToString();
                    string b = dr["bakiye"].ToString();
                    veri.idsi = dr["id"].ToString();

                    string c = dr["bagis1"].ToString();
                    string d = dr["bagis2"].ToString();
                    string f = dr["bagis3"].ToString();
                    string k = dr["fatura"].ToString();
                     string adminmi = dr["adminmi"].ToString();
                    
                    veri.cinsiyet = dr["cinsiyet"].ToString();

                    if (b.Equals("")) { b = "0"; giris.veri.bakiyesi = int.Parse(b); } else { veri.bakiyesi = int.Parse(b); }
                    if (c.Equals("")) { c = "0"; giris.veri.losev = int.Parse(c); } else { giris.veri.losev = int.Parse(c); }
                    if (d.Equals("")) { d = "0"; giris.veri.darrusafaka = int.Parse(d); } else { veri.darrusafaka = int.Parse(d); }
                    if (f.Equals("")) { f = "0"; giris.veri.gaziler = int.Parse(f); } else { veri.gaziler = int.Parse(f); }
                    if (k.Equals("")) { k = "0"; giris.veri.fatura = int.Parse(k); } else { giris.veri.fatura = int.Parse(k); }
                    dr.Close();//Onceki sorguyu kapatma islemi

                    string gizlimi1="";
                    string gizlimi2="";
                    string gizlimi3="";
                    com.CommandText = "select * from bagiskurumlari"; //Bagis kurumlarini cekme islemi
                    dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        veri.bagiskurumu1 = dr["bagisk1"].ToString();
                        veri.bagiskurumu2 = dr["bagisk2"].ToString();
                        veri.bagiskurumu3 = dr["bagisk3"].ToString();
                        
                         gizlimi1 = dr["b1kurum"].ToString();
                         gizlimi2 = dr["b2kurum"].ToString();
                         gizlimi3 = dr["b3kurum"].ToString();
                        dr.Close();
                        con.Close();
                    }
                    else { MessageBox.Show("Bagis kurumlari verileri okunmadi! Lutfen yoneticiye basvurun."); }

                    if (adminmi == "False")//admin ekranina mi girecek yoksa normal kullanici bolumune mi
                    {
                        MessageBox.Show("Hoşgeldiniz, " + veri.ad);
                        anamenu anamenu = new anamenu();
                        anamenu.Show();
                        this.Hide();

                        giris.veri.adminmi = 0;
                    }
                    else if (adminmi == "True")
                    {
                        MessageBox.Show("Hoşgeldin Admin, " + veri.ad);
                        Adminmenu adminmenu = new Adminmenu();
                        adminmenu.Show();
                        this.Hide();

                        giris.veri.adminmi = 1;
                    }   else { MessageBox.Show("Admin Veri Cekme Islemi Basarisiz Oldu! Lutfen Yoneticiye Danisiniz."); }

                                                                //Kurumlarin gizli mi degil mi ayarini isleme
                                                              if (gizlimi1 == "False")
                                                              { veri.gizlimi1 = 0; } else if (gizlimi1 == "True") { veri.gizlimi1 = 1; } else { MessageBox.Show("Gizli Kurum1 Hatali Lutfen Yoneticinize Danisiniz."); }


                                                             if (gizlimi2 == "False")
                                                              { veri.gizlimi2 = 0;  } else if (gizlimi2 == "True") { veri.gizlimi2 = 1; } else { MessageBox.Show("Gizli Kurum2 Hatali Lutfen Yoneticinize Danisiniz."); }


                                                             if (gizlimi3 == "False")
                                                              { veri.gizlimi3 = 0; }else if (gizlimi3 == "True") { veri.gizlimi3 = 1; } else { MessageBox.Show("Gizli Kurum3 Hatali Lutfen Yoneticinize Danisiniz."); }


                }
                else { MessageBox.Show("Bilgileriniz Veritabanı Kullanıcıları Bilgileri ile uyuşmuyor"); }

               
                


                

            }
            catch (Exception hatas) { MessageBox.Show("Hata! " + hatas.Message); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayit git = new kayit();
            git.Show();
            this.Hide();
        }
    }
}


