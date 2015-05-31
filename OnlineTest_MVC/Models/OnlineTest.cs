using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace OnlineTest_MVC.Models
{
    public class OnlineTest :DbContext
    {
        public OnlineTest()
            :base()
        { }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Testpaper> Testpapers { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserTest> UserTests { get; set; }

    }


}