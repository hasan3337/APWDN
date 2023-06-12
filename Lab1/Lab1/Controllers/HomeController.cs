using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab1.Models;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "User Index";
            return View();
        }

        public ActionResult Home()
        {
           
            string name = "Md. Mahmudul Hasan";
            string email = "hm677@gmail.com";
            string bio = "A Student of AIUB";

            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.Bio = bio;

            return View();
        }

        public ActionResult Profile()
        {
            Student s1 = new Student();
            
            s1.Name = "Md. Mahmudul Hasan";
            s1.DoB = "21st August";
            s1.Nationality = "Bangladeshi";
            s1.BGroup = "B+";
            s1.Address = "Dhaka";
            s1.CNo = 01377678963;
            s1.Hobby = "Hobbies";
            s1.Hobby1 = "Reading Books";
            s1.Hobby2 = "Gardening";
            s1.Hobby3 = "Hiking";

            //

            return View(s1);
        }


        
        public ActionResult Education()
        {
            MyEducation e1 = new MyEducation()
            {
                Degree = "Bsc.",
                Institute = "AIUB",
                Year = "4th Year"
            };

            MyEducation e2 = new MyEducation()
            {
                Degree = "HSC",
                Institute = "DIC",
                Year = "2018"
            };

            MyEducation e3 = new MyEducation()
            {
                Degree = "SSC",
                Institute = "DCSD",
                Year = "2016"
            };

            MyEducation[] education = new MyEducation[] { e1, e2, e3 };

            return View(education);

        }

        public ActionResult Projects()
        {
            Project p1 = new Project();
            p1.serial = 1;
            p1.course = "Web Technologies";
            p1.description = "HTML,CSS,JavaScript";

            Project p2 = new Project();
            p2.serial = 2;
            p2.course = "Advanced Web-Tech";
            p2.description = "JavaScript";

            var project = new Project[] { p1, p2 };
            return View(project);
        }

        public ActionResult Reference()
        {
            string name = "Tanvir Ahmed";
            string institute = "AIUB";
            TempData["Name"] = name;
            TempData["Institute"] = institute;
            return View();
        }


    }
}