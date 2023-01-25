using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//library sql server
using System.Data.SqlClient;
using TopUpGame.Model.Context;

namespace TopUpGame
{
    public partial class FrmLogin : Form
    {
        //setup koneksi database
        private SqlCommand cmd;
        private SqlDataReader rd;

        //deklarasi obnjek konesi
        KoneksiDB Konn = new KoneksiDB();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();  //konesi database
            conn.Open(); //membuka koneksi
            cmd = new SqlCommand("SELECT * from TBL_Akun WHERE KodeUser='" + txtUsername.Text + "' and PasswordUser='" + txtPassword.Text + "'", conn); //membaca trabel yang terdapat pada database
            rd = cmd.ExecuteReader(); //koneksi membaca file dalam database
            rd.Read(); //deklarasi fungsi read
            if(rd.HasRows)
            {
                this.Hide(); //menyembunyikan form ini
                MainMenu mainMenu = new MainMenu(); //deklarasi objek form main menu
                mainMenu.ShowDialog(); //membuka form main menu
                conn.Close(); //menutup koneksi
            }
            else
            {
                MessageBox.Show("Username atau Password salah, Silahkan coba kembali!"); //notifikasi jika salah memakukkan username atau password
            }
        }

        private void btnBuatAkun_Click(object sender, EventArgs e)
        {
            this.Hide(); //menyembunyikan form ini
            FrmBuatAkun frmBuat = new FrmBuatAkun(); //deklarasi objek form buat akun
            frmBuat.ShowDialog(); //membuka form buat akun
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
