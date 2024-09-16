using Microsoft.AspNetCore.Mvc;
using System;

namespace FirstController.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult GetMovie(int id)
        {
            return Content($" Movie With Id : {id}");

            // Action Parameter Binding 
              // 1. Form 
              // 2. Segment 
              // 3. Query String
              // 4. File 
        }
        public string DefaultAction()
        {
            return "Default Action ...";
        }
        /*public ContentResult Content()
        {
            ContentResult R = new ContentResult();
            R.Content = "Original Content";
            // R.ContentType = "text/html"; // Default ...
            return R;
        }*/
        public IActionResult Content() 
        {
            //Using HelperMethod
            return Content("Original Content", "text/html"); // Default OF ContentType "text/html"...
        }

        /*public RedirectResult Test()
        {
            RedirectResult R = new RedirectResult("https://localhost:44392/Movies/Content");
            return R;
        }*/
        public IActionResult Test()
        {
            //Using HelperMethod
            return RedirectToAction(nameof(Content));

           // return RedirectToRoute(new { Controller = "Movies", Action = "Content" });
        }
        
    }
}
