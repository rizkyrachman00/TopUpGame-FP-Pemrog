using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//3.
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopUpGame.Model.Context;

namespace TopUpGame
{
    public partial class Pembelian : Form
    {
        //4.
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        //5. deklrasi objek baru koneksi
        KoneksiDB Konn = new KoneksiDB();

        //variabel global
        string urutan;

        void KodeTransaksi()
        {
            long hitung;
            
            SqlDataReader rd;
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select KodeTransaksi from TBL_Transaksi where KodeTransaksi in (select max(KodeTransaksi) from TBL_Transaksi) order by KodeTransaksi desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();  

            if(rd.HasRows)
            {
                //jika data dalam table sudah ada

                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeTransaksi"].ToString().Length - 3, 3)) + 1;
                string kodeUrutan = "000" + hitung;
                urutan = "KdT" + kodeUrutan.Substring(kodeUrutan.Length - 3, 3);
            }
            else
            {
                urutan = "KdT001";
            }
            rd.Close();
            conn.Close();
        }

        //variabel global
        string urutan2;

        void KodeBayar()
        {
            long hitung;

            SqlDataReader rd;
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select KodeBayar from TBL_Transaksi where KodeBayar in (select max(KodeBayar) from TBL_Transaksi) order by KodeBayar desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)
            {
                //jika data dalam table sudah ada

                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBayar"].ToString().Length - 3, 3)) + 1;
                string kodeUrutan = "000" + hitung;
                urutan2 = "bYr" + kodeUrutan.Substring(kodeUrutan.Length - 3, 3);
            }
            else
            {
                urutan2 = "bYr001";
            }
            rd.Close();
            conn.Close();
        }



        public Pembelian()
        {
            InitializeComponent();
        }

        void Bersihkan()
        {
            //membersihkan textbox ketika awal di load
            textBox1.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
        }

        void isiComboBox()
        {

            comboBox1.Items.Add("Valorant");
            comboBox1.Items.Add("Mobile Legends");
            comboBox1.Items.Add("Genshin Impact");

        }

        void game1()
        {
            if (comboBox1.SelectedItem == "Valorant")
            {
                comboBox2.Items.Add("420 Points");
                comboBox2.Items.Add("700 Points");
                comboBox2.Items.Add("1375 Points");
                comboBox2.Items.Add("2400 Points");
                comboBox2.Items.Add("4000 Points");
            }
            else
            {
                comboBox2.Text = "";

            }

        }

        void game1_harga()
        {
            if (comboBox2.SelectedItem == "420 Points")
            {
                comboBox3.Items.Add("DANA - Rp. 50.000");
                comboBox3.Items.Add("OVO - Rp. 48.500");
                comboBox3.Items.Add("SPay - Rp. 51.500");

            }
            else
            {
                comboBox3.Text = "";

            }

            if (comboBox2.SelectedItem == "700 Points")
            {
                comboBox3.Items.Add("DANA - Rp. 81.000");
                comboBox3.Items.Add("OVO - Rp. 80.200");
                comboBox3.Items.Add("SPay - Rp. 79.700");

            }
            else
            {
                comboBox3.Text = "";

            }

            if (comboBox2.SelectedItem == "1375 Points")
            {
                comboBox3.Items.Add("DANA - Rp. 148.000");
                comboBox3.Items.Add("OVO - Rp. 152.000");
                comboBox3.Items.Add("SPay - Rp. 149.200");

            }
            else
            {
                comboBox3.Text = "";

            }

            if (comboBox2.SelectedItem == "2400 Points")
            {
                comboBox3.Items.Add("DANA - Rp. 249.800");
                comboBox3.Items.Add("OVO - Rp. 250.000");
                comboBox3.Items.Add("SPay - Rp. 251.200");

            }
            else
            {
                comboBox3.Text = "";

            }

            if (comboBox2.SelectedItem == "4000 Points")
            {
                comboBox3.Items.Add("DANA - Rp. 399.800");
                comboBox3.Items.Add("OVO - Rp. 400.000");
                comboBox3.Items.Add("SPay - Rp. 400.200");

            }
            else
            {
                comboBox3.Text = "";

            }

        }

        void game2()
        {
            if (comboBox1.SelectedItem == "Mobile Legends")
            {
                comboBox2.Items.Add("250 Diamonds");
                comboBox2.Items.Add("367 Diamonds");
                comboBox2.Items.Add("503 Diamonds");
                comboBox2.Items.Add("4003 Diamonds");

            }
            else
            {
                comboBox2.Text = "";

            }

        }

        void game2_harga()
        {
            if (comboBox2.SelectedItem == "250 Diamonds")
            {
                comboBox3.Items.Add("QRis - Rp. 84.360");
                comboBox3.Items.Add("DANA - Rp. 88.800");
                comboBox3.Items.Add("OVO - Rp. 85.200");

            }
            else
            {
                comboBox3.Text = "";

            }

            if (comboBox2.SelectedItem == "367 Diamonds")
            {
                comboBox3.Items.Add("QRis - Rp. 115.360");
                comboBox3.Items.Add("DANA - Rp. 122.100");
                comboBox3.Items.Add("OVO - Rp. 115.995");

            }
            else
            {
                comboBox3.Text = "";

            }

            if (comboBox2.SelectedItem == "503 Diamonds")
            {
                comboBox3.Items.Add("QRis - Rp. 158.200");
                comboBox3.Items.Add("DANA - Rp. 166.120");
                comboBox3.Items.Add("OVO - Rp. 159.100");

            }
            else
            {
                comboBox3.Text = "";

            }

            if (comboBox2.SelectedItem == "4003 Diamonds")
            {
                comboBox3.Items.Add("QRis - Rp. 1.265.400");
                comboBox3.Items.Add("DANA - Rp. 1.332.000");
                comboBox3.Items.Add("OVO - Rp. 1.300.200");

            }
            else
            {
                comboBox3.Text = "";

            }
        }


        void game3()
        {
            if (comboBox1.SelectedItem == "Genshin Impact")
            {
                comboBox2.Items.Add("6480 G-Crystals");
                comboBox2.Items.Add("3280 G-Crystals");
                comboBox2.Items.Add("1980 G-Crystals");
                comboBox2.Items.Add("960 G-Crystals");
                comboBox2.Items.Add("300 G-Crystals");

            }
            else
            {
                comboBox2.Text = "";

            }
        }

        void game3_harga()
        {
            if (comboBox2.SelectedItem == "6480 G-Crystals")
            {
                comboBox3.Items.Add("QRis - Rp. 1.598.400");
                comboBox3.Items.Add("DANA - Rp. 1.600.000");
                comboBox3.Items.Add("OVO - Rp. 1.599.200");

            }
            else
            {
                comboBox3.Text = "";

            }

            if (comboBox2.SelectedItem == "3280 G-Crystals")
            {
                comboBox3.Items.Add("QRis - Rp. 798.100");
                comboBox3.Items.Add("DANA - Rp. 799.000");
                comboBox3.Items.Add("OVO - Rp. 799.200");

            }
            else
            {
                comboBox3.Text = "";

            }

            if (comboBox2.SelectedItem == "1980 G-Crystals")
            {
                comboBox3.Items.Add("QRis - Rp. 478.100");
                comboBox3.Items.Add("DANA - Rp. 479.000");
                comboBox3.Items.Add("OVO - Rp. 479.200");

            }
            else
            {
                comboBox3.Text = "";

            }

            if (comboBox2.SelectedItem == "960 G-Crystals")
            {
                comboBox3.Items.Add("QRis - Rp. 242.100");
                comboBox3.Items.Add("DANA - Rp. 243.000");
                comboBox3.Items.Add("OVO - Rp. 241.800");

            }
            else
            {
                comboBox3.Text = "";

            }

            if (comboBox2.SelectedItem == "300 G-Crystals")
            {
                comboBox3.Items.Add("QRis - Rp. 78.300");
                comboBox3.Items.Add("DANA - Rp. 79.000");
                comboBox3.Items.Add("OVO - Rp. 78.500");

            }
            else
            {
                comboBox3.Text = "";

            }
        }



        //event
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //refresh combobox
            comboBox2.Items.Clear();
            textBox1.Text = "";
            comboBox3.Text = "";
            comboBox3.Items.Clear();

            //fungsi ketika combobox1 terdapat event
            game1();
            game2();
            game3();

        }

        //event
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            //fungsi ketika combobox2 terdapat event
            game1_harga();
            game2_harga();
            game3_harga();

        }

        private void Pembelian_Load(object sender, EventArgs e)
        {
            Bersihkan();
            isiComboBox();
            KodeTransaksi();
            KodeBayar();

        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            //validasi
            if(comboBox1.Text.Trim()=="" || textBox1.Text.Trim() == ""|| comboBox2.Text.Trim() == ""|| comboBox3.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap !!");
            }
            else
            {
                //koneksi database
                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("insert into TBL_Transaksi (JudulGame,IdGame,TopUp,MetodeBayar,KodeTransaksi,KodeBayar,TanggalBeli) values('" + comboBox1.Text + "','" + textBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + urutan + "','" + urutan2 + "' , GetDate())", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pembelian Berhasil !!");
                    KodeTransaksi();
                    KodeBayar();
                    Bersihkan();

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());  

                }


            }
        }

       
    }
}
