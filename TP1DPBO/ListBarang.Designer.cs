namespace TP1DPBO
{
    partial class ListBarang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.GambarProduk = new System.Windows.Forms.PictureBox();
            this.btnBeli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GambarProduk)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(30, 171);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(50, 13);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = "Deskripsi";
            this.lblDeskripsi.Click += new System.EventHandler(this.lblDeskripsi_Click);
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(44, 198);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(36, 13);
            this.lblHarga.TabIndex = 2;
            this.lblHarga.Text = "Harga";
            this.lblHarga.Click += new System.EventHandler(this.lblHarga_Click);
            // 
            // GambarProduk
            // 
            this.GambarProduk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GambarProduk.Location = new System.Drawing.Point(22, 15);
            this.GambarProduk.Name = "GambarProduk";
            this.GambarProduk.Size = new System.Drawing.Size(187, 130);
            this.GambarProduk.TabIndex = 3;
            this.GambarProduk.TabStop = false;
            this.GambarProduk.Click += new System.EventHandler(this.GambarProduk_Click);
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(91, 224);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(75, 23);
            this.btnBeli.TabIndex = 4;
            this.btnBeli.Text = "BELI";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // ListBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.GambarProduk);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblDeskripsi);
            this.Name = "ListBarang";
            this.Size = new System.Drawing.Size(227, 266);
            ((System.ComponentModel.ISupportInitialize)(this.GambarProduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.PictureBox GambarProduk;
        private System.Windows.Forms.Button btnBeli;
    }
}
