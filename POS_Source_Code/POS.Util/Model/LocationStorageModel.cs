using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using POS.Entity.Entities;

namespace POS.Util.Model
{
  public  class LocationStorageModel
    {
        public IEnumerable<Proc_LoadGetLocationStorage_Result> StorageLocation;
        public IEnumerable<tbl_Storage> Storages;
    }
}
