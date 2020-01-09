using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Entity;

namespace FormsAuthApp.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base(@"Data Source=SARVARBEK\SQLEXPRESS;Initial Catalog=Authentication;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework")
        { }

        public DbSet<User> User { get; set; }
    }
}