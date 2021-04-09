using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Quản_Lí_Thư_Viện.Models
{
    [Table("NhaXBs")]
    public class NhaXB
    {
        [Key]
        public string TenNhaXB { get; set; }
        public string MaNhaXB { get; set; }
        public string DiaChi { get; set; }
    }
}