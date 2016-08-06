using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entity.Entities;
using POS.Business.Interface;
using POS.Repository.UnitOfWork;
using POS.Repository;

namespace POS.Business.BusinessComponents
{
    ///Created by Srikanth Kotnala on 8/6/2016
    ///<summary>
    ///Business logic for POS Location
    /// </summary>
    public class LocationBL : ILocation
    {
        Context Context;
        /// <summary>
        /// Initialize Base Context Model
        /// </summary>
        public LocationBL()
        {
            Context = new Context();
        }

        /// <summary>
        /// Get all location from POS database
        /// </summary>
        /// <returns></returns>
        public List<tbl_Location> GetAll()
        {
            List<tbl_Location> Locations;
            try
            {
                Locations = Context.Location.Get(e=>e.City == "Jeddah").ToList();
                return Locations;
            }
            catch (Exception ex)
            {

                //POS Log Exception to db table

                return null;
            }
            finally
            {
                Locations = null;
            }

        }

        /// <summary>
        /// Get one loaction by location ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public tbl_Location GetByID(int id)
        {
            tbl_Location Location;
            try
            {
                Location = Context.Location.GetByID(id);
                return Location;
            }
            catch (Exception ex)
            {

                //POS Log Exception to db table

                return null;
            }
            finally
            {
                Location = null;
                Context = null;
            }

        }

        /// <summary>
        /// Insert location by location model
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public bool Insert(tbl_Location location)
        {
            try
            {
                Context.Location.Insert(location);
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
                Context = null;
            }

        }

        /// <summary>
        /// Update location by location model
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public bool Update(tbl_Location location)
        {
            try
            {
                Context.Location.Update(location);
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
                Context = null;
            }

        }

        /// <summary>
        /// Delete location by id
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public bool DeleteByID(int id)
        {
            try
            {
                Context.Location.Delete(id);
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
                Context = null;
            }

        }

        /// <summary>
        /// Delete location by location model
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public bool DeleteByLocationDetails(tbl_Location location)
        {
            try
            {
                Context.Location.Delete(location);
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
                Context = null;
            }

        }
    }
}
