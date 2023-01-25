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
    public partial class FrmBuatAkun : Form
    {
        //setup koneksi database
        private SqlCommand cmd;

        //deklarasi obnjek konesi
        KoneksiDB Konn = new KoneksiDB();

        public FrmBuatAkun()
        {
            InitializeComponent();
        }
        
        private void btnBuatAkun_Click(object sender, EventArgs e)
        {

            //validasi
            if (txtKodeUser.Text.Trim() == "" || txtNamaUser.Text.Trim() == "" || txtPasswordUser.Text.Trim() == "")
            {
                MessageBox.Show("Data belum di isi. Silahkan input data !");
            }
            else
            {
                SqlConnection conn = Konn.GetConn(); //konesi database
                conn.Open(); //membuka koneksi
                cmd = new SqlCommand("INSERT into TBL_Akun values (@KodeUser,@NamaUser,@PasswordUser,@LevelUser)", conn); //memasukkan data ke tabel database
                cmd.Parameters.AddWithValue("@KodeUser", txtKodeUser.Text); //memasukan data KodeUser
                cmd.Parameters.AddWithValue("@NamaUser", txtNamaUser.Text); //memasukan data NamaUser
                cmd.Parameters.AddWithValue("@PasswordUser", txtPasswordUser.Text); //memasukan data PasswordUser
                cmd.Parameters.AddWithValue("@LevelUser", "USER"); //memasukan data (otomatis akan terisi "USER")
                cmd.ExecuteNonQuery(); //mengeksekusi script SQL diatas
                conn.Close(); //menutup koneksi

                //notifikasi jika akun sudah terdaftar
                MessageBox.Show("Akun terlah terdaftar");

                this.Hide(); //menyembunyikan form ini
                FrmLogin frmLogin = new FrmLogin(); //deklarasi objek form loigin
                frmLogin.ShowDialog(); //membuka form buat akun
            }
                
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
