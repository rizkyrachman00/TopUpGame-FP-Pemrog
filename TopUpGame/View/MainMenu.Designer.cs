namespace TopUpGame
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRiwayat = new FontAwesome.Sharp.IconButton();
            this.btnTopUp = new FontAwesome.Sharp.IconButton();
            this.btnGameList = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.btnRiwayat);
            this.panelMenu.Controls.Add(this.btnTopUp);
            this.panelMenu.Controls.Add(this.btnGameList);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 632);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 35;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 467);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogOut.Size = new System.Drawing.Size(220, 60);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 546);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.FlatAppearance.BorderSize = 0;
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRiwayat.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnRiwayat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRiwayat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRiwayat.IconSize = 35;
            this.btnRiwayat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiwayat.Location = new System.Drawing.Point(0, 342);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRiwayat.Size = new System.Drawing.Size(220, 60);
            this.btnRiwayat.TabIndex = 3;
            this.btnRiwayat.Text = "Riwayat Top-Up";
            this.btnRiwayat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiwayat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRiwayat.UseVisualStyleBackColor = true;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // btnTopUp
            // 
            this.btnTopUp.FlatAppearance.BorderSize = 0;
            this.btnTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopUp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTopUp.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.btnTopUp.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTopUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTopUp.IconSize = 35;
            this.btnTopUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopUp.Location = new System.Drawing.Point(0, 282);
            this.btnTopUp.Name = "btnTopUp";
            this.btnTopUp.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTopUp.Size = new System.Drawing.Size(220, 60);
            this.btnTopUp.TabIndex = 2;
            this.btnTopUp.Text = "Top-Up Game";
            this.btnTopUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTopUp.UseVisualStyleBackColor = true;
            this.btnTopUp.Click += new System.EventHandler(this.btnTopUp_Click);
            // 
            // btnGameList
            // 
            this.btnGameList.FlatAppearance.BorderSize = 0;
            this.btnGameList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGameList.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.btnGameList.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGameList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGameList.IconSize = 35;
            this.btnGameList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGameList.Location = new System.Drawing.Point(0, 222);
            this.btnGameList.Name = "btnGameList";
            this.btnGameList.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGameList.Size = new System.Drawing.Size(220, 60);
            this.btnGameList.TabIndex = 1;
            this.btnGameList.Text = "Game List";
            this.btnGameList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGameList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGameList.UseVisualStyleBackColor = true;
            this.btnGameList.Click += new System.EventHandler(this.btnGameList_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(10, 9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(187, 125);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(962, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(881, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(39, 28);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(920, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(836, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(39, 28);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(168)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(64, 26);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(50, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(9)))), ((int)(((byte)(108)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(168)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(168)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(13, 16);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(962, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(962, 548);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(962, 548);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 632);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnRiwayat;
        private FontAwesome.Sharp.IconButton btnTopUp;
        private FontAwesome.Sharp.IconButton btnGameList;
        private Panel panelLogo;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton btnLogOut;
    }
}