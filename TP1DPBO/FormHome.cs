using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1DPBO.Properties;

namespace TP1DPBO
{
    public partial class FormHome : Form {
        User pengguna = new User();
        public ListBarang[] barang = new ListBarang[5];
        public FormHome()
        {
            InitializeComponent();

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            Barang();

        }

        private void Barang()
        {
            label2.Visible = false;
            for (int i = 0; i < barang.Length; i++)
            {
                barang[i] = new ListBarang();
                if (i == 1)
                {
                    barang[i].Deskripsi = "Smartphone";
                    barang[i].Harga = "Rp.1.000.000";
                    barang[i].Gambar = Resources.smartphone;
                    barang[i].Button = "btnBeli1";
                }
                else if (i == 2)
                {
                    barang[i].Deskripsi = "Sepatu";
                    barang[i].Harga = "Rp.100.000";
                    barang[i].Gambar = Resources.shoe;
                    barang[i].Button = "btnBeli2";
                }
                else if (i == 3)
                {
                    barang[i].Deskripsi = "Gaun";
                    barang[i].Harga = "Rp.850.000";
                    barang[i].Gambar = Resources.dress;
                    barang[i].Button = "btnBeli3";
                }
                else if (i == 4)
                {
                    barang[i].Deskripsi = "Kopi";
                    barang[i].Harga = "Rp.100.000";
                    barang[i].Gambar = Resources.coffee;
                    barang[i].Button = "btnBeli4";
                }
                else if (i == 5)
                {
                    barang[i].Deskripsi = "Salad";
                    barang[i].Harga = "Rp.400.000";
                    barang[i].Gambar = Resources.salad;
                    barang[i].Button = "btnBeli5";
                }

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(barang[i]);
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
       {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBeli_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin Flogin = new FormLogin();
            Flogin.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbJenisBarang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (cbJenisBarang.SelectedItem == null || cbRangeHarga.SelectedItem == null)
            {
                MessageBox.Show("Harap Masukan Jenis Barang / Range Harga");
                Barang();
            }
            else
            {
                if (cbJenisBarang.SelectedItem == "Baju")
                {
                    if (cbRangeHarga.SelectedItem == "100.000 - 200.000")
                    {
                        label2.Visible = true;
                        flowLayoutPanel1.Controls.Add(barang[1]);
                    }
                    else if (cbRangeHarga.SelectedItem == "200.000 - 500.000")
                    {
                        MessageBox.Show("Maaf Barang Tidak Ada");
                        Barang();
                    }
                    else
                    {
                        MessageBox.Show("Maaf Barang Tidak Ada");
                        Barang();
                    }
                }
                else if (cbJenisBarang.SelectedItem == "Elektronik")
                {
                    if (cbRangeHarga.SelectedItem == "100.000 - 200.000")
                    {
                        MessageBox.Show("Maaf Barang Tidak Ada");
                        Barang();
                    }
                    else if (cbRangeHarga.SelectedItem == "200.000 - 500.000")
                    {
                        MessageBox.Show("Maaf Barang Tidak Ada");
                        Barang();
                    }
                    else
                    {
                        label2.Visible = true;
                        flowLayoutPanel1.Controls.Add(barang[0]);
                    }
                }
                else if (cbJenisBarang.SelectedItem == "Makanan")
                {
                    if (cbRangeHarga.SelectedItem == "100.000 - 200.000")
                    {
                        label2.Visible = true;
                        flowLayoutPanel1.Controls.Add(barang[3]);
                    }
                    else if (cbRangeHarga.SelectedItem == "200.000 - 500.000")
                    {
                        label2.Visible = true;
                        flowLayoutPanel1.Controls.Add(barang[4]);
                    }
                    else
                    {
                        MessageBox.Show("Maaf Barang Tidak Ada");
                        Barang();
                    }
                }
            }
        }
    }
}
