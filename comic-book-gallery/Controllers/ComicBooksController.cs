using System;
using System.Web.Mvc;

namespace comicbookgallery.Controllers
{
    public class ComicBooksController : Controller
    {
        /*
        public string Detail()
        {
            return "Hello from the comic books controller!";
        }
        */


        //public ContentResult Detail()
        //public ActionResult Detail()
        //{
        //    if(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
        //    {
        //        //return new RedirectResult("/");
        //        return Redirect("/");
        //    }

        //    /*return new ContentResult()
        //    {
        //        Content = "Hello from the comic books controller!"
        //    };*/
        //    return Content("Hello from the comic books controller!");
        //}


        public ActionResult Detail()
        {
            return View();   
        }


    }
}
