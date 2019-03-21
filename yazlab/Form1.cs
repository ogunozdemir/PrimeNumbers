using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazlab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string veritabani = "Data Source=CONFI-PC;Initial Catalog=yazlab;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(veritabani);

        bool calis = false;
        int tambolen;
        int threaddegeri;


        private void btnbasla_Click(object sender, EventArgs e)
        {
            if (calis == true)
            {
                MessageBox.Show("Program zaten çalışıyor.");
            }

            else
            {
                calis = true;
                Thread basla = new Thread(delegate () { motor(); });

                basla.Start();
            }

            
        }

        public void motor()
        {
            while (calis == true)
            {
                System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;

                Thread start3 = new Thread(delegate () { });
               
                listBox1.Items.Clear();
                baglanti.Open();
                int b = Convert.ToInt32(lblsayi.Text);
                double c = Math.Sqrt(b);
                int tvn = Convert.ToInt32(c);
                int threadsayisi = 0;
                int tvnid = 0;
             
                SqlCommand komut2 = new SqlCommand("SELECT * from asal where sayilar <= '" + tvn + "' ", baglanti);
                SqlDataReader oku2 = komut2.ExecuteReader();
                while (oku2.Read())
                {
                  
                    tvnid = Convert.ToInt32(oku2["ID"]);

                }


                oku2.Close();
                baglanti.Close();

                int d = 0;
                baglanti.Open();
                SqlCommand komut21 = new SqlCommand("SELECT count(*) from asal where sayilar<="+tvn, baglanti);
                d = (Int32)komut21.ExecuteScalar();
                baglanti.Close();

                if (d <= 100)
                {
                    threadsayisi = 2;
                }
                if (d > 100)
                {
                    threadsayisi = Convert.ToInt32((d / 100) + 1);
                }

                label4.Text = "Kullanılacak Thread Sayısı: " + threadsayisi.ToString();

                Thread[] start2 = new Thread[threadsayisi];

                bool[] asaldizi = new bool[threadsayisi];
                int pay = tvnid / threadsayisi;
                int kalan = tvnid % threadsayisi;

                int parametre1 = 1, parametre2 = pay;
                int deneme = 0;

                while (deneme < threadsayisi)
                {

                    deneme++;

                    start2[deneme - 1] = new Thread(() =>
                    {

                        asaldizi[deneme - 1] = asilthread(parametre1, parametre2, b);
                    }
                         );

                    listBox1.Items.Add("Thread "+deneme+" -  taban ID:" + parametre1 + "   tavan ID:" + parametre2);

                    start2[deneme - 1].Start();
                    start2[deneme - 1].Join(1000);
                    
                    if (deneme == threadsayisi - 1)
                    {
                        parametre1 = pay + parametre1;
                        parametre2 = pay + parametre2 + kalan;
                    }
                    else
                    {
                        parametre1 = pay + parametre1;
                        parametre2 = pay + parametre2;
                    }

                }


                bool bitti = true;

                while (bitti)
                {

                    for (int i = 0; i < threadsayisi; i++)
                    {


                        if (start2[i].Join(1))
                        {

                            bitti = false;
                        }
                        else
                        {
                            bitti = true;
                            break;
                        }
                    }

                    if (bitti == false)
                    {

                        bool kontrol = true;
                        for (int i = 0; i < threadsayisi; i++)
                        {
                            if (asaldizi[i] == false)
                            {
                                kontrol = false;
                                threaddegeri = i+1;
                                break;
                            }

                        }

                        if (kontrol == true)
                        {
                            label9.Text = "Sayı asal sayıdır!";

                            start3 = new Thread(delegate ()
                            {

                                threadkayit(b);
                            }
                                   );
                            start3.Start();

                            while (true)
                            {
                                if (start3.Join(1))
                                {
                                    b = Convert.ToInt32(lblsayi.Text);
                                    lblsonuc.Text = b.ToString();
                                    b += 2;
                                    lblsayi.Text = b.ToString();
                                    break;
                                }


                            }
                        }
                        else
                        {
                            label9.Text = "Sayı asal değildir!\nThread "+threaddegeri+" da bulunan "+ tambolen+" sayısına tam olarak bölünmektedir.";

                            b = Convert.ToInt32(lblsayi.Text);
                            lblsonuc.Text = b.ToString();
                            b += 2;
                            lblsayi.Text = b.ToString();
                        }
                    }
                }
            }
        }

        public bool asilthread(int paraa1, int paraa2, int sayi)
        {
            bool durum = true;
            for (int i = paraa1; i <= paraa2; i++)
            {
         
                SqlConnection baglanti = new SqlConnection(veritabani);
                baglanti.Open();

                SqlCommand komut = new SqlCommand("SELECT sayilar from asal where ID = '" + i + "' ", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    string a = oku["sayilar"].ToString();
                    int d = Convert.ToInt32(a);

                    if (sayi % d == 0)
                    {
                        durum = false;
                        tambolen = d;
                        break;
                    }

                }

                oku.Close();
                baglanti.Close();
                }

                return durum;
        }

        private void threadkayit(int p11)
        {
            SqlConnection baglanti = new SqlConnection(veritabani);

            int id = 0;
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT TOP 1 * from asal order by ID DESC ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            if (oku2.Read())
            {

                id = Convert.ToInt32(oku2["ID"]) + 1;
            }

            oku2.Close();
            baglanti.Close();

            baglanti.Open();
            string kayit = "insert into asal(ID,sayilar) values ('"+id+"',@sayilar)";
            SqlCommand komut3 = new SqlCommand(kayit, baglanti);
            komut3.Parameters.AddWithValue("@sayilar", p11.ToString());
            komut3.ExecuteNonQuery();
            baglanti.Close();


           
        }


        void sondeger()
        {


            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("SELECT max(sayilar) from asal ", baglanti);
            SqlDataReader dr = komut5.ExecuteReader();

            while (dr.Read())
            {

                String a = dr[""].ToString();
                int sayi = Convert.ToInt32(a);
                sayi = sayi + 2;
                lblsayi.Text = sayi.ToString();
            }
            dr.Close();
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            sondeger();

        }

        private void btnbitir_Click(object sender, EventArgs e)
        {

            if (calis == false)
            {
                MessageBox.Show("Program zaten çalışmıyor.");
            }

            else
            {
                calis = false;

                listBox2.Items.Clear();
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("SELECT * from asal", baglanti);
                SqlDataReader oku2 = komut2.ExecuteReader();
                while (oku2.Read())
                {

                    listBox2.Items.Add(Convert.ToInt32(oku2["ID"]) + "   -   " + Convert.ToInt32(oku2["sayilar"]));

                }

                oku2.Close();
                baglanti.Close();
            }   
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
