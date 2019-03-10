using System.Web.Mvc;
using Vidly1.Models;

namespace Vidly1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var Movie = new Movie() { Name = "Raja Hindustani" };
             return View(Movie);

            //return Content("Hello World !");

            // return HttpNotFound();

            //return new EmptyResult();  

            //return RedirectToAction("Index", "Home", new { page = 1, Sortby ="name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortby)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortby))
                sortby = "Name";
            return Content(string.Format("pageIndex = {0}&sortby = {1}", pageIndex, sortby));


        }

    }
}