using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RenderDynamicMenuPractice.Controllers
{
    public class Item
    {
        public string LinkDetails { get; set; }
        public string ItemId { get; set; }

        public string ParentId { get; set; }

        public int Level { get; set; }

        public bool hasChild { get; set; }

    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult GetMenuItem()
        {
            var main1 = new Item { LinkDetails = "#", Level = 1, ParentId = "", ItemId = "item1" };
            var main2 = new Item { LinkDetails = "#", Level = 1, ParentId = "", ItemId = "item2" };
            var main3 = new Item { LinkDetails = "#", Level = 1, ParentId = "", ItemId = "item3", hasChild = true };
            var main4 = new Item { LinkDetails = "#", Level = 1, ParentId = "", ItemId = "item4" };
            var listMain = new List<Item>() { main1, main2, main3, main4 };



            return Json(listMain, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetMenuChildren()
        {
            var main1 = new Item { LinkDetails = "#", Level = 1, ParentId = "", ItemId = "item5" };
            var main2 = new Item { LinkDetails = "#", Level = 1, ParentId = "", ItemId = "item6" };
            var main3 = new Item { LinkDetails = "#", Level = 1, ParentId = "", ItemId = "item7", hasChild = true };
            var main4 = new Item { LinkDetails = "#", Level = 1, ParentId = "", ItemId = "item8" };
            var listMain = new List<Item>() { main1, main2, main3, main4 };



            return Json(listMain, JsonRequestBehavior.AllowGet);
        }

    }
}
