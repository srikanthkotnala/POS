using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entity.Entities;
using POS.Business.Interface;
using POS.Repository.UnitOfWork;
using POS.Repository;
using POS.Util.Model;

namespace POS.Business.BusinessComponents
{
    /// Created by Vinod kumar 16/08/2016
    /// <summary>
    /// Business Logic for Storage
    /// </summary>
    public class StorageBL : IStorage
    {
        Context Context;
        /// <summary>
        /// Initialize Base Context Model
        /// </summary>
        public StorageBL()
        {
            Context = new Context();
        }

        /// <summary>
        /// Get all storage from POS database
        /// </summary>
        /// <returns></returns>
        public List<tbl_Storage> GetAll()
        {
            List<tbl_Storage> storage;
            try
            {
                storage = Context.Storage.Get().ToList();
                return storage;
            }
            catch (Exception ex)
            {

                //POS Log Exception to db table

                return null;
            }
            finally
            {
                storage = null;
            }

        }
        /// <summary>
        /// Get All Location 
        /// </summary>
        /// <returns></returns>
        public List<tbl_Location> GetAllLocation()
        {
            List<tbl_Location> location;
            try
            {
                location = Context.Location.Get().ToList();
                return location;
            }
            catch (Exception ex)
            {
                //POS Log Exception to db table

                return null;
            }
            finally
            {
                location = null;
            }
        }

        /// <summary>
        /// Get one storage by Storage ID and LocationID
        /// </summary>
        /// <param name="storageid"></param>
        /// <param name="locationid"></param>
        /// <returns></returns>
        public tbl_Storage GetByID(string locationid)
        {
            tbl_Storage storage;
            try
            {
                storage = Context.Storage.GetByID(locationid);
                return storage;
            }
            catch (Exception ex)
            {

                //POS Log Exception to db table

                return null;
            }
            finally
            {
                storage = null;
                // Context = null;
            }

        }

        /// <summary>
        /// Insert Storage by Storage model
        /// </summary>
        /// <param name="storage"></param>
        /// <returns></returns>
        public string Insert(tbl_Storage storage)
        {
            try
            {
                Context.Storage.Insert(storage);
                Context.Storage.Save();
                return storage.LocationID + "," + storage.StorageID + " Inserted Successfully!!";
            }
            catch (Exception ex)
            {

                //POS Log Exception to db table

                return "Error in saving details, Please try again!!";
            }
            finally
            {
                // Context = null;
            }

        }

        /// <summary>
        /// Update storage by storage model
        /// </summary>
        /// <param name="storage"></param>
        /// <returns></returns>
        public string Update(tbl_Storage storage)
        {
            try
            {
                Context.Storage.Update(storage);
                Context.Storage.Save();
                return storage.StorageID + "," + storage.LocationID + " Updated Successfully!!";
            }
            catch (Exception ex)
            {

                //POS Log Exception to db table

                return "Error in saving details, Please try again!!";
            }
            finally
            {
                // Context = null;
            }

        }

        /// <summary>
        /// Delete storage by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteByID(int id)
        {
            try
            {
                Context.Storage.Delete(id);
                Context.Location.Save();
                return true;
            }
            catch (Exception ex)
            {

                //POS Log Exception to db table

                return false;
            }
            finally
            {
                // Context = null;
            }

        }

        /// <summary>
        /// Delete storage by storage model
        /// </summary>
        /// <param name="storage"></param>
        /// <returns></returns>
        public bool DeleteByLocationDetails(tbl_Storage storage)
        {
            try
            {
                Context.Storage.Delete(storage);
                Context.Storage.Save();
                return true;
            }
            catch (Exception ex)
            {

                //POS Log Exception to db table

                return false;
            }
            finally
            {
                // Context = null;
            }

        }

        /// <summary>
        /// Insert or Update in tbl_Storage table -Vinod 
        /// </summary>
        /// <param name="storage"></param>
        /// <returns></returns>
        public string InsertOrUpdate(tbl_Storage storage)
        {
            tbl_Storage CurrentStorage = this.GetByID(storage.LocationID);
            string result = string.Empty;
            if (CurrentStorage == null)
            {
                return result = this.Insert(storage);
            }
            else
            {
                return result = this.Update(storage);
            }
        }
        /// <summary>
        /// Get Storage
        /// </summary>
        /// <returns></returns>
        public List<Proc_LoadGetLocationStorage_Result> GetStorage()
        {
            List<Proc_LoadGetLocationStorage_Result> LoadGetStorage;
            try
            {
                LoadGetStorage = Context.GetAllStorage().ToList();
                return LoadGetStorage;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {

            }
        }

      
    }
}
