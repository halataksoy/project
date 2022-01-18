using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models.DataContext;
using Project.Models.Model;
using System.Web.Helpers;
using System.Web.Mvc;
namespace Project.Controllers
{
    public class ProjectController : Controller
    {
        ProjectDbContext dbContext = new ProjectDbContext();
        // GET: Project
        public ActionResult Index()
        {

            return View();
        }

        private List<object> GetResultList()
        {
            dbContext.
            return null;
        }
    }
}