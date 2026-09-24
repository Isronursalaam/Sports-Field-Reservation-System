namespace Sports_Field_Reservation_System
{
    partial class FormKelolaLapangan
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
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnTransaksi = new Button();
            btnKelolaLapangan = new Button();
            btnUsers = new Button();
            txtCari = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textNamaLap = new TextBox();
            btnHapus = new Button();
            btnEdit = new Button();
            btnTambah = new Button();
            dgvUsers = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(27, 191);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 22);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 19;
            label1.Text = "Reservasi Lapangan";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo_PPK_Ormawa_2025__2_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(27, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnTransaksi
            // 
            btnTransaksi.Location = new Point(27, 243);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(94, 29);
            btnTransaksi.TabIndex = 17;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.UseVisualStyleBackColor = true;
            // 
            // btnKelolaLapangan
            // 
            btnKelolaLapangan.Location = new Point(27, 344);
            btnKelolaLapangan.Name = "btnKelolaLapangan";
            btnKelolaLapangan.Size = new Size(140, 29);
            btnKelolaLapangan.TabIndex = 16;
            btnKelolaLapangan.Text = "Kelola Lapangan";
            btnKelolaLapangan.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(27, 287);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(94, 29);
            btnUsers.TabIndex = 15;
            btnUsers.Text = "Kelola Users";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(631, 149);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(125, 27);
            txtCari.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 25);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 28;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 25);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 27;
            label2.Text = "Telepon";
            // 
            // textNamaLap
            // 
            textNamaLap.Location = new Point(278, 48);
            textNamaLap.Name = "textNamaLap";
            textNamaLap.Size = new Size(125, 27);
            textNamaLap.TabIndex = 25;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(469, 135);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(81, 29);
            btnHapus.TabIndex = 24;
            btnHapus.Text = "hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(376, 135);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(87, 29);
            btnEdit.TabIndex = 23;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(281, 135);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(89, 29);
            btnTambah.TabIndex = 22;
            btnTambah.Text = "tambah";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(278, 182);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(478, 242);
            dgvUsers.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 30;
            // 
            // FormKelolaLapangan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(txtCari);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textNamaLap);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnTambah);
            Controls.Add(dgvUsers);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnTransaksi);
            Controls.Add(btnKelolaLapangan);
            Controls.Add(btnUsers);
            Name = "FormKelolaLapangan";
            Text = "FormKelolaLapangan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnTransaksi;
        private Button btnKelolaLapangan;
        private Button btnUsers;
        private TextBox txtCari;
        private Label label3;
        private Label label2;
        private TextBox textNamaLap;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnTambah;
        private DataGridView dgvUsers;
        private TextBox textBox1;
    }
}