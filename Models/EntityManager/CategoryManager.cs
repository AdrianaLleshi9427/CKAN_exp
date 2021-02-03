using System;
using System.Linq;
using TravelAgency.DAL;
using TravelAgency.Models;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TravelAgency.Models.EntityManager
{
    public class CategoryManager
    {
        public void AddCategories(CategoryDetail category)
        {

            using (dbMyOnlineShoppingEntities db = new dbMyOnlineShoppingEntities())
            {

                Tbl_Category CA = new Tbl_Category();
                CA.CategoryName = category.CategoryName;

                db.Tbl_Category.Add(CA);
                db.SaveChanges();
            }
        }
    }
}