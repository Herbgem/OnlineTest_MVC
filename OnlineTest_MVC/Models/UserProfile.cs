using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTest_MVC.Models
{
    public class UserProfile
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserProfileId { get; set; }
        [MaxLength(255), Column(TypeName="nvarchar")]
        public string UserName { get; set; }
        [MaxLength(255), Column(TypeName = "nvarchar")]
        public string Password { get; set; }
        [MaxLength(255), Column(TypeName = "nvarchar")]
        public string Email { get; set; }
        [MaxLength(255), Column(TypeName = "nvarchar")]
        public string Gender { get; set; }
        [MaxLength(255), Column(TypeName = "nvarchar")]
        public string Mobile { get; set; }
    }
}