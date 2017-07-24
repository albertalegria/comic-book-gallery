﻿using System;
using System.Web.Mvc;
using comicbookgallery.Models;

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


   //     public ActionResult Detail()
   //     {
			//ViewBag.SeriesTitle = "The Amazing Spider-Man";
			//ViewBag.IssueNumber = 700;
			//ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
			//ViewBag.Artists = new string[]
			//{
			//	"Script: Dan Slott",
			//	"Pencils: Humberto Ramos",
			//	"Inks: Victor Olazaba",
			//	"Colors: Edgar Delgado",
			//	"Letters: Chris Eliopoulos"
			//};

        //    return View();   
        //}

        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters" }
                },
                Favorite = false
            };

            return View(comicBook);
        }


    }
}
