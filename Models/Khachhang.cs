namespace WebsiteBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Khachhang")]
    public partial class Khachhang
    {
        [Key]
        public string MaKhachHang { get; set; }

        public string TenKhachHang { get; set; }

        [StringLength(15)]
        public string SoDienThoai { get; set; }
    }
}
