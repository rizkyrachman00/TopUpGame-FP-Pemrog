namespace TopUpGame
{
    partial class RiwayatPembelian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiwayatPembelian));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCariRiwayat = new System.Windows.Forms.TextBox();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnHapus = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtCariRiwayat);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnHapus);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 501);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtCariRiwayat
            // 
            this.txtCariRiwayat.Location = new System.Drawing.Point(289, 34);
            this.txtCariRiwayat.Name = "txtCariRiwayat";
            this.txtCariRiwayat.Size = new System.Drawing.Size(537, 27);
            this.txtCariRiwayat.TabIndex = 2;
            this.txtCariRiwayat.TextChanged += new System.EventHandler(this.txtCariRiwayat_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 24;
            this.btnClear.Location = new System.Drawing.Point(836, 450);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 39);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "CLEAR";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHapus.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnHapus.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHapus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHapus.IconSize = 24;
            this.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapus.Location = new System.Drawing.Point(836, 393);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(96, 39);
            this.btnHapus.TabIndex = 1;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(804, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // RiwayatPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.panel1);
            this.Name = "RiwayatPembelian";
            this.Text = "RiwayatPembelian";
            this.Load += new System.EventHandler(this.RiwayatPembelian_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnHapus;
        private FontAwesome.Sharp.IconButton btnClear;
        private TextBox txtCariRiwayat;
        private PictureBox pictureBox1;
    }
}