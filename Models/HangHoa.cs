namespace WebsiteBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HangHoa")]
    public partial class HangHoa
    {
        [Key]
        [StringLength(20)]
        public string MaHangHoa { get; set; }

        [Required]
        [StringLength(50)]
        public string TenHangHoa { get; set; }

        public decimal DonGia { get; set; }

        [Required]
        [StringLength(15)]
        public string DonViTinh { get; set; }

        [Required]
        [StringLength(15)]
        public string MaNCC { get; set; }
    }
}
