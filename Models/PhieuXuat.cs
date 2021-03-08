namespace WebsiteBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuXuat")]
    public partial class PhieuXuat
    {
        [Key]
        [StringLength(20)]
        public string MaPhieuXuat { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTao { get; set; }

        [Required]
        [StringLength(15)]
        public string MaKhachHang { get; set; }
    }
}
