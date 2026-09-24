using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sports_Field_Reservation_System
{

    public class users
    {
        public int id { get; set; }
        public string nama { get; set; } = string.Empty;
        public string telepon { get; set; } = string.Empty;

    }

    public class lapangan
    {
        public int id { get; set; }
        public string nama { get; set; } = string.Empty;
        public string jenis { get; set; } = string.Empty;
        public int harga { get; set; }

    }
    internal class Database : DbContext
    {
        public DbSet<users> users => Set<users>();
        public DbSet<lapangan> lapangan => Set<lapangan>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-VBF7UU3H\\SQLEXPRESS;Initial Catalog=ReservasiLapanganDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
