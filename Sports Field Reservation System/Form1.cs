namespace Sports_Field_Reservation_System
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            showdata();
        }
        int kolom = 1;
        void showdata()
        {
            using var db = new Database();
            var data = db.users.ToList();

            dgvUsers.DataSource = data;
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textNama.Text) || (string.IsNullOrEmpty(txtTelepon.Text)))
            {
                MessageBox.Show("!", "Tidak Boleh Kosong");
                return;
            }

            using var db = new Database();
            var baru = new users
            {
                nama = textNama.Text.Trim(),
                telepon = txtTelepon.Text.Trim()
            };

            db.users.Add(baru);
            db.SaveChanges();
            showdata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (kolom == 0)
            {
                return;
            }

            using var db = new Database();
            var edit = db.users.FirstOrDefault(u => u.id == kolom);
            if (edit != null)
            {
                edit.nama = textNama.Text.Trim();
                edit.telepon = txtTelepon.Text.Trim();

                db.SaveChanges();
                showdata();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (kolom == 0)
            {
                return;
            }

            using var db = new Database();
            var hapus = db.users.FirstOrDefault(u => u.id == kolom);
            if (hapus != null)
            {
                db.users.Remove(hapus);
                db.SaveChanges();
                showdata();
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var baris = dgvUsers.Rows[e.RowIndex];
                kolom = Convert.ToInt32(baris.Cells[0].Value);

                using var db = new Database();
                var data = db.users.FirstOrDefault(u => u.id == kolom);
                if (data != null)
                {
                    textNama.Text = data.nama;
                    txtTelepon.Text = data.telepon;

                }
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            var kunci = txtCari.Text.Trim();

            using var db = new Database();
            var cari = db.users.Where(u => u.nama.StartsWith(kunci)).ToList();
            dgvUsers.DataSource = cari;
        }

        private void btnKelolaLapangan_Click(object sender, EventArgs e)
        {
            new FormKelolaLapangan().Show();
            this.Close();
            return;
        }
    }
}
