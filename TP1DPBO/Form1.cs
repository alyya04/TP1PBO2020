using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1DPBO
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            User pengguna = new User();
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            pengguna.Username = Convert.ToString(username);
            pengguna.Password = Convert.ToString(password);

            if(username.Trim() == string.Empty || password.Trim() == string.Empty)
            {
                MessageBox.Show("Mohon Untuk Mengisi Username dan Password Terlebih Dahulu");
            }
            else
            {
                if(password == "pbo123")
                {
                    FormHome home = new FormHome();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Maaf Password Yang Anda Masukan Salah!");
                }
            }
        }
    }
}
