using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Quản_Lí_Thư_Viện.Models
{
    public partial class QLTHUVIENDbContext : DbContext
    {
        public QLTHUVIENDbContext()
            : base("name=QLTHUVIENDbContext")
        {
        }

        public virtual DbSet<BangThuThu> BangThuThus { get; set; }
        public virtual DbSet<DangKyCaBiet> DangKyCaBiets { get; set; }
        public virtual DbSet<MuonTra> MuonTras { get; set; }
        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<NhaXB> NhaXBs { get; set; }
        public virtual DbSet<Sach> Sachs { get; set; }
        public virtual DbSet<KhoSachcs> KhoSachcs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
