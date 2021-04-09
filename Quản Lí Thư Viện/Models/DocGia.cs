using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quản_Lí_Thư_Viện.Models
{
    [Table("DocGias")]
    public class DocGia
    {
        [Key]
        public string SoThe { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string ChoOHienTai { get; set; }
        public string NgayCapThe { get; set; }
        public string HanDungThe { get; set; }

    }
}