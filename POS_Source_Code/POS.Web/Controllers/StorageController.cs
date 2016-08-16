using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POS.Business.BusinessComponents;
using POS.Entity.Entities;
using POS.Util.Model;
namespace POS.Web.Controllers
{
    ///Created by Vinod on 16/08/2016
    ///<summary>
    ///Storage Controller
    /// </summary>
    public class StorageController : Controller
    {
        StorageBL StorageBL;
        public StorageController()
        {
            StorageBL = new StorageBL();
        }

        // GET: Storage
        public ActionResult Index()
        {
            LocationStorageContext LSC = new LocationStorageContext();
            
            return View();
        }
    }
}