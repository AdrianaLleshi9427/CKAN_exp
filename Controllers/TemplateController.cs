using Newtonsoft.Json;
using TravelAgency.DAL;
using TravelAgency.Models;
using TravelAgency.Models.Home;
using TravelAgency.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TravelAgency.Controllers
{
    public class TemplateController : Controller
    {

        dbMyOnlineShoppingEntities ctx = new dbMyOnlineShoppingEntities();
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();

        // GET: Template
        public ActionResult Template1()
        {
            return View();
        }

        public ActionResult page00()
        {
            return View();
        }

        public ActionResult page01()
        {
            return View();
        }

        public ActionResult page02()
        {
            return View();
        }

        public ActionResult page03()
        {
            return View();
        }

    }
}