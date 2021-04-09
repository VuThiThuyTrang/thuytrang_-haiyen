using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quản_Lí_Thư_Viện.Models
{
    [Table("BangThuThus")]
    public class BangThuThu
    {
        [Key]
        public string MaThuThu { get; set; }
        public string TenThuThu { get; set; }
        public string DiaChi { get; set; }
        public string MatKhau { get; set; }
    }
}