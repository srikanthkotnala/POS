using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entity.Entities;
using POS.Repository;

namespace POS.Repository.UnitOfWork
{
    ///Created by Srikanth Kotnala on 8/4/2016
    ///Unit of work for POS database objects.
    public class Context
    {
        POSEntities pOSEntities;
        public Context()
        {
            pOSEntities = new POSEntities();
        }

        /// <summary>
        ///Unit of work for POS database tables.
        /// </summary>
        #region Data Model Repository Properties

        private GenericRepository<tbl_Location> location;
        /// <summary>
        /// tbl_Location table property as Location
        /// </summary>
        public GenericRepository<tbl_Location> Location
        {
            get
            {
                if (this.location == null)
                {
                    this.location = new GenericRepository<tbl_Location>(EntityConstant.POS);
                }
                return location;
            }
            set
            {
                this.location = new GenericRepository<tbl_Location>(EntityConstant.POS);
            }
            
        }

        /// <summary>
        /// tbl_Storage table property as Storage
        /// </summary>
        private GenericRepository<tbl_Storage> storage;

        public GenericRepository<tbl_Storage> Storage
        {
            get {
                if(this.storage==null)
                {
                    this.storage = new GenericRepository<tbl_Storage>(EntityConstant.POS);
                }
                return storage;
            }
            set {
                this.storage = new GenericRepository<tbl_Storage>(EntityConstant.POS);
            }
        }



        #endregion

        /// <summary>
        ///Unit of work for POS database Stored Procedures.
        /// </summary>
        #region POS Stored Procedures
        /// <summary>
        /// SP Description
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Proc_GetMasterCategory_Result> GetMasterCategory(string CategoryID)
        {
            return pOSEntities.Proc_GetMasterCategory(CategoryID).ToList();
        }

      
        /// <summary>
        /// Get all location details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Proc_LoadMasterLocation_Result> GetAllLocation()
        {
            return pOSEntities.Proc_LoadMasterLocation().ToList();
        }

        #endregion
    }
}
