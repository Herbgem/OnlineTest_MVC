using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTest_MVC.Models
{
    public class UserTest
    {
        public int UserTestId { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Testpaper Testpaper { get; set; }
    }
}