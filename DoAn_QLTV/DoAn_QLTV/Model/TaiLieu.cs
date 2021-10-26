namespace DoAn_QLTV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiLieu")]
    public partial class TaiLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiLieu()
        {
            CTPhieuMuons = new HashSet<CTPhieuMuon>();
        }

        [Key]
        [StringLength(10)]
        public string MaTaiLieu { get; set; }

        [StringLength(50)]
        public string TenTaiLieu { get; set; }

        public int? NamXB { get; set; }

        [Required]
        [StringLength(10)]
        public string MaTG { get; set; }

        [Required]
        [StringLength(10)]
        public string MaTheLoai { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNXB { get; set; }

        public virtual NhaXuatBan NhaXuatBan { get; set; }

        public virtual TacGia TacGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuMuon> CTPhieuMuons { get; set; }

        public virtual TheLoai TheLoai { get; set; }
    }
}
