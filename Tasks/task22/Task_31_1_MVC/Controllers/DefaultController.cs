using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_31_1_MVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {



            return View();
        }


        public string contactUS()
        {



            return "Welcome in ContactUS";
        }


        public string AboutUS()
        {



            return "Welcome in About us";
        }
        public ActionResult displayImage()
        {
            //var imagePath = Path.Combine(Server.MapPath("~/images"), "logo21.png");
            //return File(imagePath, "image/jpeg");

            //string path = Server.MapPath("images\\logo12.PNG");
            //byte[] imageByteData = System.IO.File.ReadAllBytes(path);
            //return File(imageByteData, "image/png");
           

            //return View();


            ////////////////////////////////////////////
            ///
            return Content("<p>Click on the image to download it:<p>" +
                   "\r\n<a href='../images/logo21.png' download>" +
                   "\r\n  <img src='..\\images\\logo21.PNG' alt='W3Schools' " +
                   "width='104' height='142'>\r\n</a> <br><a href='https://localhost:44301/Default/contactUS' > <h2>Contact Us</h2></a><br> <a href='https://localhost:44301/Default/AboutUS'><h2>About Us </h2></a><br>" +
                   "<a href='https://localhost:44301/Empty/Name'> <h2>Name</h2> </a>" +
                   "<a href='https://localhost:44301/Empty/color'> <h2> color</h2> </a> <br>" +
                   "<a href='https://localhost:44301/Empty/Age'> <h2> Age</h2> </a>" +
                   "<br>" +
                   "<a href='https://localhost:44301/Empty/code'> <h2> Code</h2> </a>");
        }

        public ActionResult DownloadImage()
        {
            //var path = Path.Combine(Server.MapPath("~/images"), "logo21.png");
            //return File(path, "image/jpeg", "logo21.png");

            return Content("<a href='/images/logo21.png' download><img src='..\\images\\logo21.PNG' width='100'><a>");
        }

    }
}