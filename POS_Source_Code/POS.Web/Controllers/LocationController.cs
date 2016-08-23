﻿using POS.Business.BusinessComponents;
using POS.Entity.Entities;
using POS.Util.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;

namespace POS.Web.Controllers
{
    ///Created by Srikanth Kotnala on 8/13/2016
    ///<summary>
    ///Location Controller
    /// </summary>
    public class LocationController : Controller
    {
        LocationBL LocationBL;
        public LocationController()
        {
            LocationBL = new LocationBL();
        }
        // GET: Location
        public ActionResult Index()
        {
            List<tbl_Location> lstLocations=  LocationBL.GetAll();
            return View(lstLocations);
        }

        /// <summary>
        /// Get Location details By ID -Srikanth
        /// </summary>
        /// <param name="locationID"></param>
        /// <returns></returns>
        public PartialViewResult GetLocationByID(string locationID)
        {
            LocationModel LM = new LocationModel();
            tbl_Location location = LocationBL.GetByID(locationID.Trim());
            LM.LocationID = location.LocationID;
            LM.LocationDesc = location.LocationDesc;
            LM.Address1 = location.Address1;
            LM.Address2 = location.Address2;
            LM.Address3 = location.Address3;
            LM.POBox = location.POBox;
            LM.Contact = location.Contact;
            LM.Phone = location.Phone;
            LM.Fax = location.Fax;
            LM.Email = location.Email;
            LM.City = location.City;
            LM.Region = location.Region;
            LM.Country = location.Country;
            LM.BusinessArea = location.BusinessArea;
            LM.FieldArea = location.FieldArea;
            LM.CashLoan = location.CashLoan;

            return PartialView("~/Views/Location/Partial/_LocationDetailsPartial.cshtml", LM);
        }

        public string InsertOrUpdateLocation(LocationModel LM)
        {
            tbl_Location location = new tbl_Location();
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
            location.BusinessArea = LM.BusinessArea;
            location.FieldArea = LM.FieldArea;
            location.CashLoan = LM.CashLoan;
            return LocationBL.InsertOrUpdate(location);
        }
    }
}