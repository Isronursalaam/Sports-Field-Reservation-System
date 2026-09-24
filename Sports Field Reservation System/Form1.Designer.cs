namespace Sports_Field_Reservation_System
{
    partial class FormUser
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
            btnUsers = new Button();
            btnKelolaLapangan = new Button();
            btnTransaksi = new Button();
            dgvUsers = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            textNama = new TextBox();
            txtTelepon = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            txtCari = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(23, 287);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(94, 29);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Kelola Users";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnKelolaLapangan
            // 
            btnKelolaLapangan.Location = new Point(23, 344);
            btnKelolaLapangan.Name = "btnKelolaLapangan";
            btnKelolaLapangan.Size = new Size(140, 29);
            btnKelolaLapangan.TabIndex = 1;
            btnKelolaLapangan.Text = "Kelola Lapangan";
            btnKelolaLapangan.UseVisualStyleBackColor = true;
            btnKelolaLapangan.Click += btnKelolaLapangan_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.Location = new Point(23, 243);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(94, 29);
            btnTransaksi.TabIndex = 2;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(307, 191);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(478, 242);
            dgvUsers.TabIndex = 3;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo_PPK_Ormawa_2025__2_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(23, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 22);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 5;
            label1.Text = "Reservasi Lapangan";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(309, 106);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(89, 29);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(404, 106);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(87, 29);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(497, 106);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(81, 29);
            btnHapus.TabIndex = 8;
            btnHapus.Text = "hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // textNama
            // 
            textNama.Location = new Point(307, 57);
            textNama.Name = "textNama";
            textNama.Size = new Size(125, 27);
            textNama.TabIndex = 9;
            // 
            // txtTelepon
            // 
            txtTelepon.Location = new Point(477, 57);
            txtTelepon.Name = "txtTelepon";
            txtTelepon.Size = new Size(125, 27);
            txtTelepon.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(477, 34);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 12;
            label2.Text = "Telepon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 34);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 13;
            label3.Text = "Nama";
            // 
            // button1
            // 
            button1.Location = new Point(23, 191);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(660, 158);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(125, 27);
            txtCari.TabIndex = 15;
            txtCari.TextChanged += txtCari_TextChanged;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 458);
            Controls.Add(txtCari);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTelepon);
            Controls.Add(textNama);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnTambah);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvUsers);
            Controls.Add(btnTransaksi);
            Controls.Add(btnKelolaLapangan);
            Controls.Add(btnUsers);
            Name = "FormUser";
            Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUsers;
        private Button btnKelolaLapangan;
        private Button btnTransaksi;
        private DataGridView dgvUsers;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnTambah;
        private Button btnEdit;
        private Button btnHapus;
        private TextBox textNama;
        private TextBox txtTelepon;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtCari;
    }
}
