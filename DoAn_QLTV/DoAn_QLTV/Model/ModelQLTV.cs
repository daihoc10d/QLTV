using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn_QLTV.Model
{
    public partial class ModelQLTV : DbContext
    {
        public ModelQLTV()
            : base("name=ModelQLTV")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public virtual DbSet<PhieuMuon> PhieuMuons { get; set; }
        public virtual DbSet<TacGia> TacGias { get; set; }
        public virtual DbSet<TaiLieu> TaiLieux { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<CTPhieuMuon> CTPhieuMuons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.TenAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.MKAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.MaDG)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .HasMany(e => e.PhieuMuons)
                .WithRequired(e => e.DocGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuMuons)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaXuatBan>()
                .Property(e => e.MaNXB)
                .IsUnicode(false);

            modelBuilder.Entity<NhaXuatBan>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhaXuatBan>()
                .HasMany(e => e.TaiLieux)
                .WithRequired(e => e.NhaXuatBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuMuon>()
                .Property(e => e.MaPM)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuMuon>()
                .Property(e => e.MaDG)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuMuon>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuMuon>()
                .HasMany(e => e.CTPhieuMuons)
                .WithRequired(e => e.PhieuMuon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TacGia>()
                .Property(e => e.MaTG)
                .IsUnicode(false);

            modelBuilder.Entity<TacGia>()
                .HasMany(e => e.TaiLieu)
                .WithRequired(e => e.TacGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiLieu>()
                .Property(e => e.MaTaiLieu)
                .IsUnicode(false);

            modelBuilder.Entity<TaiLieu>()
                .Property(e => e.MaTG)
                .IsUnicode(false);

            modelBuilder.Entity<TaiLieu>()
                .Property(e => e.MaTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<TaiLieu>()
                .Property(e => e.MaNXB)
                .IsUnicode(false);

            modelBuilder.Entity<TaiLieu>()
                .HasMany(e => e.CTPhieuMuons)
                .WithRequired(e => e.TaiLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.MaTheLoai)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai>()
                .HasMany(e => e.TaiLieux)
                .WithRequired(e => e.TheLoai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTPhieuMuon>()
                .Property(e => e.MaPM)
                .IsUnicode(false);

            modelBuilder.Entity<CTPhieuMuon>()
                .Property(e => e.MaTaiLieu)
                .IsUnicode(false);
        }
    }
}
