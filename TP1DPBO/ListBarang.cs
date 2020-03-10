using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1DPBO
{
    public partial class ListBarang : UserControl
    {
        public ListBarang()
        {
            InitializeComponent();
        }

        private string _deskripsi;
        private string _harga;
        private Image _gambar;
        private string _button;

        [Category("Custom Props")]
        public string Deskripsi
        {
            get { return _deskripsi; }
            set { _deskripsi = value; lblDeskripsi.Text = value; }
        }

        [Category("Custom Props")]
        public string Harga
        {
            get { return _harga; }
            set { _harga = value; lblHarga.Text = value; }
        }

        [Category("Custom Props")]
        public Image Gambar
        {
            get { return _gambar; }
            set { _gambar = value; GambarProduk.Image = value; }
        }

        [Category("Custom Props")]
        public string Button
        {
            get { return _button; }
            set { _button = value; btnBeli.Name = value; }
        }
        private void btnBeli_Click(object sender, EventArgs e)ssSs
        {

        }

        private void GambarProduk_Click(object sender, EventArgs e)
        {

        }

        private void lblDeskripsi_Click(object sender, EventArgs e)
        {

        }

        private void lblHarga_Click(object sender, EventArgs e)
        {

        }
    }
}
