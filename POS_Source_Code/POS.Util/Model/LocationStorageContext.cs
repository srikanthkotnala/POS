using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entity.Entities;


namespace POS.Util.Model
{
   public  class LocationStorageContext : DbContext
    {
        public DbSet<tbl_Location> LocationS { get; set; }
        public DbSet<tbl_Storage> Storages { get; set; }
    }
}
