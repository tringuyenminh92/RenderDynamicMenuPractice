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

        public JsonResult GetMainMenuItem()
        {
            var main1 = new Item { LinkDetails = "#", Level = 1, ParentId = "", ItemId = "item1" };
            var main2 = new Item { LinkDetails = "#", Level = 1, ParentId = "", ItemId = "item2", hasChild = true };
            var main3 = new Item { LinkDetails = "#", Level = 1, ParentId = "", ItemId = "item3", hasChild = true };
            var main4 = new Item { LinkDetails = "#", Level = 1, ParentId = "", ItemId = "item4" };
            var listMain = new List<Item>() { main1, main2, main3, main4 };

            return Json(listMain, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetMenuChildrenItem()
        {
            var main1 = new Item { LinkDetails = "#", Level = 2, ParentId = "item3", ItemId = "item5" };
            var main2 = new Item { LinkDetails = "#", Level = 2, ParentId = "item3", ItemId = "item6", hasChild = true };
            var main3 = new Item { LinkDetails = "#", Level = 2, ParentId = "item2", ItemId = "item7" };
            var main4 = new Item { LinkDetails = "#", Level = 2, ParentId = "item3", ItemId = "item8" };

            var main9 = new Item { LinkDetails = "#", Level = 3, ParentId = "item6", ItemId = "item9" };
            var main10 = new Item { LinkDetails = "#", Level = 3, ParentId = "item6", ItemId = "item10", hasChild = true };
            var main11 = new Item { LinkDetails = "#", Level = 3, ParentId = "item6", ItemId = "item11" };
            var main12 = new Item { LinkDetails = "#", Level = 3, ParentId = "item6", ItemId = "item12" };

            var main13 = new Item { LinkDetails = "#", Level = 4, ParentId = "item10", ItemId = "item13" };
            var main14 = new Item { LinkDetails = "#", Level = 4, ParentId = "item10", ItemId = "item14" };
            var main15 = new Item { LinkDetails = "#", Level = 4, ParentId = "item10", ItemId = "item15" };
            var main16 = new Item { LinkDetails = "#", Level = 4, ParentId = "item10", ItemId = "item16" };

            var listMain = new List<Item>() { main1, main2, main3, main4, main9, main10, main11, main12, main13, main14, main15, main16 };

            return Json(listMain, JsonRequestBehavior.AllowGet);
        }

    }
}
