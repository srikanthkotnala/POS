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
            List <Proc_LoadGetLocationStorage_Result> locationStorage= StorageBL.GetStorage().ToList();
            return View(locationStorage);
        }

        public PartialViewResult GetStorageByID(string locationID)
        {
            tbl_Storage storage = StorageBL.GetByID(locationID);
            return PartialView("~/Views/Storage/Partial/_StorageDetailsPartial.cshtml", storage);
        }
        public string InsertOrUpdateStorage(tbl_Storage storage)
        {
            return StorageBL.InsertOrUpdate(storage);
        }
    }
}