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
   public class CategoryBL
    {
        Context Context;
        public CategoryBL()
        {
            Context = new Context();
        }
        /// <summary>
        /// Get all Category from POS database
        /// </summary>
        /// <returns></returns>
        public List<tbl_Category> GetCategoryAll()
        {
            List<tbl_Category> Category;
            try
            {
                Category = Context.category.Get().ToList();
                return Category;
            }
            catch (Exception ex)
            {

                //POS Log Exception to db table

                return null;
            }
            finally
            {
                Category = null;
            }

        }
        /// <summary>
        /// Get one Category by Category ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public tbl_Category GetByID(string id)
        {
            tbl_Category Category;
            try
            {
                Category = Context.category.GetByID(id);
                return Category;
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
        /// Insert Terminal by Terminal model
        /// </summary>
        /// <param name="terminal"></param>
        /// <returns></returns>
        public string Insert(tbl_Category category)
        {
            try
            {
                Context.category.Insert(category);
                Context.category.Save();
                return category.CategoryID + " Inserted Successfully!!";
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
        /// Update Vendir by Vendor model
        /// </summary>
        /// <param name="terminal"></param>
        /// <returns></returns>
        public string Update(tbl_Category category)
        {
            try
            {
                Context.category.Update(category);
                Context.category.Save();
                return category.CategoryID + " Updated Successfully!!";
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
    }
}
