using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTest_MVC.Models
{
    public class TestResult
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TestResultId { get; set; }
        public int Score { get; set; }
        [MaxLength(255), Column(TypeName="nvarchar")]
        public string Grade { get; set; }
        public virtual Testpaper Testpaper { get; set; }
    }
}