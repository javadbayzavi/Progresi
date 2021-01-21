using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using services.Models;

namespace services.Models
{
    public class BunchdbContext: DbContext
    {
        public DbSet<> MyProperty { get; set; }
        public BunchdbContext():base("")
            {

        }
    }
}