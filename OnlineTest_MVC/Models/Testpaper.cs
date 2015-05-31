using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTest_MVC.Models
{
    public class Testpaper
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TestpaperId { get; set; }
        [MaxLength(255), Column(TypeName="nvarchar")]
        public string Question { get; set; }
        [MaxLength(255), Column(TypeName = "nvarchar")]
        public string Option1 { get; set; }
        [MaxLength(255), Column(TypeName = "nvarchar")]
        public string Option2 { get; set; }
        [MaxLength(255), Column(TypeName = "nvarchar")]
        public string Option3 { get; set; }
        [MaxLength(255), Column(TypeName = "nvarchar")]
        public string Option4 { get; set; }
        [MaxLength(255), Column(TypeName = "nvarchar")]
        public string Answer { get; set; }
        public virtual Subject Subject { get; set; }
    }
}