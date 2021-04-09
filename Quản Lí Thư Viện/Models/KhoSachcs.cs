using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quản_Lí_Thư_Viện.Models
{
    [Table("KhoSachs")]
    public class KhoSachcs
    {
        [Key]
        public int MaKho { get; set; }
        public string TenKho { get; set; }
        public int GhiChu { get; set; }
    }
}