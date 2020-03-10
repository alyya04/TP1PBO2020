namespace TP1DPBO
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCari = new System.Windows.Forms.Button();
            this.cbRangeHarga = new System.Windows.Forms.ComboBox();
            this.cbJenisBarang = new System.Windows.Forms.ComboBox();
            this.lblJenisBarang = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblSemuaProduk = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnKatalog = new System.Windows.Forms.Button();
            this.btnBeli = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.btnCari);
            this.panel1.Controls.Add(this.cbRangeHarga);
            this.panel1.Controls.Add(this.cbJenisBarang);
            this.panel1.Controls.Add(this.lblJenisBarang);
            this.panel1.Controls.Add(this.lblHarga);
            this.panel1.Controls.Add(this.lblSemuaProduk);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnKatalog);
            this.panel1.Controls.Add(this.btnBeli);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "KEMBALI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(187, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(582, 287);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(694, 48);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 12;
            this.btnCari.Text = "CARI";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // cbRangeHarga
            // 
            this.cbRangeHarga.FormattingEnabled = true;
            this.cbRangeHarga.Location = new System.Drawing.Point(507, 48);
            this.cbRangeHarga.Name = "cbRangeHarga";
            this.cbRangeHarga.Size = new System.Drawing.Size(149, 21);
            this.cbRangeHarga.TabIndex = 11;
            this.cbRangeHarga.Text = "Masukan Range Harga";
            // 
            // cbJenisBarang
            // 
            this.cbJenisBarang.FormattingEnabled = true;
            this.cbJenisBarang.Location = new System.Drawing.Point(342, 48);
            this.cbJenisBarang.Name = "cbJenisBarang";
            this.cbJenisBarang.Size = new System.Drawing.Size(149, 21);
            this.cbJenisBarang.TabIndex = 10;
            this.cbJenisBarang.Text = "Masukan Jenis Barang";
            this.cbJenisBarang.SelectedIndexChanged += new System.EventHandler(this.cbJenisBarang_SelectedIndexChanged);
            // 
            // lblJenisBarang
            // 
            this.lblJenisBarang.AutoSize = true;
            this.lblJenisBarang.Location = new System.Drawing.Point(376, 22);
            this.lblJenisBarang.Name = "lblJenisBarang";
            this.lblJenisBarang.Size = new System.Drawing.Size(85, 13);
            this.lblJenisBarang.TabIndex = 9;
            this.lblJenisBarang.Text = "JENIS BARANG";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(559, 22);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(45, 13);
            this.lblHarga.TabIndex = 8;
            this.lblHarga.Text = "HARGA";
            // 
            // lblSemuaProduk
            // 
            this.lblSemuaProduk.AutoSize = true;
            this.lblSemuaProduk.Location = new System.Drawing.Point(199, 88);
            this.lblSemuaProduk.Name = "lblSemuaProduk";
            this.lblSemuaProduk.Size = new System.Drawing.Size(94, 13);
            this.lblSemuaProduk.TabIndex = 7;
            this.lblSemuaProduk.Text = "SEMUA PRODUK";
            this.lblSemuaProduk.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(51, 379);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 35);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnKatalog
            // 
            this.btnKatalog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKatalog.Image = ((System.Drawing.Image)(resources.GetObject("btnKatalog.Image")));
            this.btnKatalog.Location = new System.Drawing.Point(20, 245);
            this.btnKatalog.Name = "btnKatalog";
            this.btnKatalog.Size = new System.Drawing.Size(147, 114);
            this.btnKatalog.TabIndex = 5;
            this.btnKatalog.Text = "Menu Katalog";
            this.btnKatalog.UseVisualStyleBackColor = true;
            // 
            // btnBeli
            // 
            this.btnBeli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBeli.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBeli.Image = ((System.Drawing.Image)(resources.GetObject("btnBeli.Image")));
            this.btnBeli.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBeli.Location = new System.Drawing.Point(20, 116);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(147, 123);
            this.btnBeli.TabIndex = 4;
            this.btnBeli.Text = "Menu Beli";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox2.Location = new System.Drawing.Point(19, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 316);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnKatalog;
        private System.Windows.Forms.Label lblSemuaProduk;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox cbRangeHarga;
        private System.Windows.Forms.ComboBox cbJenisBarang;
        private System.Windows.Forms.Label lblJenisBarang;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}