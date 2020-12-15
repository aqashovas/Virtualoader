using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VRBack.Models
{
    public class VirtualLoaderContext : DbContext
    {
        public VirtualLoaderContext() : base("VirtualLoaderContext")
        {
        }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Conference> Conferences { get; set; }
    }
}