﻿using System;
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
                Locations = Context.Location.Get().ToList();
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
        public tbl_Location GetByID(string id)
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
                //Location = null;
                // Context = null;
            }

        }

        /// <summary>
        /// Insert location by location model
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public string Insert(tbl_Location location)
        {
            try
            {
                Context.Location.Insert(location);
                Context.Location.Save();
                return location.LocationDesc + " Inserted Successfully!!";
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
        /// Update location by location model
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public string Update(tbl_Location location)
        {
            try
            {
                Context.Location.Update(location);
                Context.Location.Save();
                return location.LocationDesc + " Updated Successfully!!";
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
                // Context = null;
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
                // Context = null;
            }

        }

        /// <summary>
        /// Insert or Update in tbl_Location table -Srikanth 
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public string InsertOrUpdate(LocationModel LM)
        {
            string result = string.Empty;
            bool isExist = false;
            tbl_Location location;
            location = this.GetByID(LM.LocationID.Trim());
            if (location != null)
            {
                isExist = true;
            }
            else
            {
                location = new tbl_Location();
            }
            location.LocationID = LM.LocationID;
            location.LocationDesc = LM.LocationDesc;
            location.Address1 = LM.Address1;
            location.Address2 = LM.Address2;
            location.Address3 = LM.Address3;
            location.POBox = LM.POBox;
            location.Contact = LM.Contact;
            location.Phone = LM.Phone;
            location.Fax = LM.Fax;
            location.Email = LM.Email;
            location.City = LM.City;
            location.Region = LM.Region;
            location.Country = LM.Country;
            location.FieldArea = LM.FieldArea;
            location.CashLoan = LM.CashLoan;
            if (!isExist)
            {

                return result = this.Insert(location);
            }
            else
            {
                return result = this.Update(location);
            }
        }
    }
}
