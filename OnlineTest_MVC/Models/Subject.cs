using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTest_MVC.Models
{
    public class Subject
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }
        [MaxLength(255), Required, Column(TypeName="nvarchar")]
        public string SubjectName { get; set; }
    }
}