using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Entity.Entities;
using POS.Repository;
using POS.Repository.UnitOfWork;
using POS.Util.Model;

namespace POS.Business.BusinessComponents
{
    public class MaterialBL
    {
        ///Created by Vinod
        ///<summary>
        ///Business logic for POS Terminal
        /// </summary>
        Context Context;

        public MaterialBL()
        {
            Context = new Context();
        }


        /// <summary>
        /// Get all Material from POS database
        /// </summary>
        /// <returns></returns>
        public List<tbl_Material> GetAll()
        {
            List<tbl_Material> Material;
            try
            {
                Material = Context.Material.Get().ToList();
                return Material;
            }
            catch (Exception ex)
            {

                //POS Log Exception to db table

                return null;
            }
            finally
            {
                Material = null;
            }

        }
        /// <summary>
        /// Get one material by material ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<tbl_Material> GetByID(string id)
        {
            List<tbl_Material> Material;
            try
            {
                Material = Context.Material.Get(e => e.MaterialID == id).ToList();
                return Material;
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
        /// Insert material by material model
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public string Insert(tbl_Material material)
        {
            try
            {
                Context.Material.Insert(material);
                Context.Material.Save();
                return material.MaterialID + " Inserted Successfully!!";
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
        /// Update terminal by terminal model
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public string Update(tbl_Material material)
        {
            try
            {
                Context.Material.Update(material);
                Context.Material.Save();
                return material.MaterialID + " Updated Successfully!!";
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
        /// Delete Terminal by LocationID,TerminalID
        /// </summary>
        /// <param name="MaterialID"></param>
        /// <returns></returns>
        public bool DeleteByID(string MaterialID)
        {
            try
            {
                Context.Material.Delete(MaterialID);
                Context.Material.Save();
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
        /// Get All Category List
        /// </summary>
        /// <returns></returns>
        public List<tbl_Category> GetAllCategory()
        {
            List<tbl_Category> Category;
            try
            {
                Category = Context.Category.Get().ToList();
                return Category;
            }
            catch (Exception ex)
            {

                //POS Log Exception to db table

                return null;
            }
            finally
            {
               // Category = null;
            }
        }

        public List<tbl_SubCategory> GetAllSubCategory()
        {
            List<tbl_SubCategory> SubCategory;
            try
            {
                SubCategory = Context.SubCategory.Get().ToList();
                return SubCategory;

            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {

            }
        }
        public List<tbl_Vendor> GetAllVendor()
        {
            List<tbl_Vendor> Vendor;
            try
            {
                Vendor = Context.Vendor.Get().ToList();
                return Vendor;
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {

            }
        }


        /// <summary>
        /// Insert or Update in tbl_material table -Vinod 
        /// </summary>
        /// <param name="Material"></param>
        /// <returns></returns>
        public string InsertOrUpdate(tbl_Material material)
        {
            string result = string.Empty;
           
            return result;
        }

        public MaterialModel GetMterialModel()
        {
            List<tbl_Category> Category;
            List<tbl_SubCategory> SubCategory;
            List<tbl_Vendor> Vendor;
            MaterialModel MaterialModel;
            try
            {
                MaterialModel = new MaterialModel();
                Category = this.GetAllCategory();
                SubCategory = this.GetAllSubCategory();
                Vendor = this.GetAllVendor();

                MaterialModel.GetAllCategory = Category;
                MaterialModel.GetAllSubCategory = SubCategory;
                MaterialModel.GetAllVendor = Vendor;

                return MaterialModel;
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                Category = null;
                SubCategory = null;
                Vendor = null;
            }
        }
    }
}
