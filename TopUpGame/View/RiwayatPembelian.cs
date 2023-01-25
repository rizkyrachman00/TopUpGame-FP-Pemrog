using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//3.
using System.Data.SqlClient;
using TopUpGame.Model.Context;

namespace TopUpGame
{
    public partial class RiwayatPembelian : Form
    {
        //4.
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        //5. deklrasi objek baru koneksi
        KoneksiDB Konn = new KoneksiDB();

        public RiwayatPembelian()
        {
            InitializeComponent();
        }

        void tampilRiwayat()
        {
            //menampilkan database ke grid view
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select KodeTransaksi,JudulGame,IdGame,TopUp,MetodeBayar,TanggalBeli from TBL_Transaksi", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Transaksi");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_Transaksi";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                //menutup koneksi
                conn.Close();
            }

        }

        void cariRiwayat()
        {
            //menampilkan database ke grid view
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("Select KodeTransaksi,JudulGame,IdGame,TopUp,MetodeBayar,TanggalBeli from TBL_Transaksi where KodeTransaksi like '%" + txtCariRiwayat.Text + "%' or JudulGame like '%" + txtCariRiwayat.Text + "%'  ", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_Transaksi");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_Transaksi";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                //menutup koneksi
                conn.Close();
            }

        }


        private void RiwayatPembelian_Load(object sender, EventArgs e)
        {
            tampilRiwayat();

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Yakin akan menghapus data riwayat transaksi ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //koneksi
                SqlConnection conn = Konn.GetConn();

                {
                    string selected = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    cmd = new SqlCommand("delete from TBL_Transaksi where KodeTransaksi='" + selected + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete berhasil !!");
                    tampilRiwayat();
                }

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Yakin akan menghapus semua riwayat transaksi ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //menampilkan database ke grid view
                SqlConnection conn = Konn.GetConn();

                {
                    cmd = new SqlCommand("delete from TBL_Transaksi where KodeTransaksi=Kodetransaksi", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete berhasil !!");
                    tampilRiwayat();
                }

            }

        }

        private void txtCariRiwayat_TextChanged(object sender, EventArgs e)
        {
            cariRiwayat();
        }
    }
}
