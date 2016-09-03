using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entity.Entities;
using POS.Repository;
using POS.Util.Model;

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
            get
            {
                if (this.storage == null)
                {
                    this.storage = new GenericRepository<tbl_Storage>(EntityConstant.POS);
                }
                return storage;
            }
            set
            {
                this.storage = new GenericRepository<tbl_Storage>(EntityConstant.POS);
            }
        }

        /// <summary>
        /// Location Storage property Model as LocationStorageModel
        /// </summary>
        private GenericRepository<LocationStorageModel> locationstorage;

        public GenericRepository<LocationStorageModel> LocationStorage
        {
            get
            {
                if (this.locationstorage == null)
                {
                    this.locationstorage = new GenericRepository<LocationStorageModel>(EntityConstant.POS);
                }
                return locationstorage;
            }
            set
            {
                this.locationstorage = new GenericRepository<LocationStorageModel>(EntityConstant.POS);
            }
        }

        private GenericRepository<tbl_Terminal> terminal;

        public GenericRepository<tbl_Terminal> Terminal
        {
            get
            {
                if (this.terminal == null)
                {
                    this.terminal = new GenericRepository<tbl_Terminal>(EntityConstant.POS);
                }
                return terminal;
            }
            set
            {
                this.terminal = new GenericRepository<tbl_Terminal>(EntityConstant.POS);
            }
        }

        public GenericRepository<tbl_Vendor> vendor;
        public GenericRepository<tbl_Vendor> Vendor
        {
            get
            {
                if(this.vendor==null)
                {
                    this.vendor = new GenericRepository<tbl_Vendor>(EntityConstant.POS);
                }
                return vendor;
            }
            set
            {
                this.vendor = new GenericRepository<tbl_Vendor>(EntityConstant.POS);
            }

        }

        public GenericRepository<tbl_City> city;
        public GenericRepository<tbl_City> City
        {
            get
            {
                if(this.city==null)
                {
                    this.city = new GenericRepository<tbl_City>(EntityConstant.POS);
                }
                return city;
            }
            set
            {
                this.city = new GenericRepository<tbl_City>(EntityConstant.POS);
            }
        }

        public GenericRepository<tbl_Country> country;
        public GenericRepository<tbl_Country> Country
        {
            get
            {
                if(this.country==null)
                {
                    this.country = new GenericRepository<tbl_Country>(EntityConstant.POS);
                }
                return country;
            }
            set
            {
                this.country = new GenericRepository<tbl_Country>(EntityConstant.POS);
            }
        }
        public GenericRepository<tbl_Region> region;
        public GenericRepository<tbl_Region> Region
        {
            get
            {
                if(this.region==null)
                {
                    this.region = new GenericRepository<tbl_Region>(EntityConstant.POS);
                }
                return region;
            }
            set
            {
                this.region = new GenericRepository<tbl_Region>(EntityConstant.POS);
            }
        }
        public GenericRepository<tbl_Category> category;
        public GenericRepository<tbl_Category> Category
        {
            get
            {
                if(category==null)
                {
                    this.category = new GenericRepository<tbl_Category>(EntityConstant.POS);
                }
                return category;
            }
            set
            {
                this.category = new GenericRepository<tbl_Category>(EntityConstant.POS);
            }
        }

        public GenericRepository<tbl_Material> material;
        public GenericRepository<tbl_Material> Material
        {
            get
            {
                if(material==null)
                {
                    this.material = new GenericRepository<tbl_Material>(EntityConstant.POS);
                }
                return material;
            }
            set
            {
                this.material = new GenericRepository<tbl_Material>(EntityConstant.POS);
            }
            
        }

        public GenericRepository<tbl_SubCategory> subcategory;
        public GenericRepository<tbl_SubCategory> SubCategory
        {
            get
            {
                if(subcategory==null)
                {
                    this.subcategory = new GenericRepository<tbl_SubCategory>(EntityConstant.POS);
                }
                return subcategory;
            }
            set
            {
                this.subcategory = new GenericRepository<tbl_SubCategory>(EntityConstant.POS);
            }
        }
        public GenericRepository<tbl_UOM> uom;
        public GenericRepository<tbl_UOM> UOM
        {
            get
            {
                if(uom==null)
                {
                    this.uom = new GenericRepository<tbl_UOM>(EntityConstant.POS);
                }
                return uom;
            }
            set
            {
                this.uom = new GenericRepository<tbl_UOM>(EntityConstant.POS);
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

        /// <summary>
        /// Get All Storage and location Inner Join
        /// </summary>
        /// <returns></returns>
        public List<Proc_LoadGetLocationStorage_Result> GetAllStorage()
        {
            return pOSEntities.Proc_LoadGetLocationStorage().ToList();
        }
        /// <summary>
        /// Get Storage By Id-Vinod InnerJoin
        /// </summary>
        /// <param name="LocationID"></param>
        /// <returns></returns>
        public List<Proc_LoadStorageGetById_Result> GetStorageById(string LocationID)
        {
            return pOSEntities.Proc_LoadStorageGetById(LocationID).ToList();
        }

        public List<Proc_GetAllLTerminal_Result> GetAllTerminal()
        {
            return pOSEntities.Proc_GetAllLTerminal().ToList();
        }
        public List<Proc_GetMasterTerminal_Result> GetMTeminal(string LocationID)
        {
            return pOSEntities.Proc_GetMasterTerminal(LocationID).ToList();
        }

        #endregion
    }
}
