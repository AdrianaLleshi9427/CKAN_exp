using System;
using System.Linq;
using TravelAgency.DAL;
using TravelAgency.Models;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TravelAgency.Models.EntityManager
{
    public class UserManager
    {
        public void AddUserAccount(RegisterViewModel user)
        {

            using (dbMyOnlineShoppingEntities db = new dbMyOnlineShoppingEntities())
            {

                Tbl_Members SU = new Tbl_Members();
                SU.EmailId = user.EmailId;
                SU.Password = user.Password;
                SU.FristName = user.FristName;
                SU.LastName = user.LastName;
                SU.CreatedOn = DateTime.Now;
                SU.ModifiedOn = DateTime.Now;

                db.Tbl_Members.Add(SU);
                db.SaveChanges();
            }
        }
    }
}