namespace DoAn_QLTV.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPhieuMuon")]
    public partial class CTPhieuMuon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaPM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaTaiLieu { get; set; }

        public DateTime? NgayMuon { get; set; }

        public DateTime? NgayTra { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        public virtual PhieuMuon PhieuMuon { get; set; }

        public virtual TaiLieu TaiLieu { get; set; }
    }
}
