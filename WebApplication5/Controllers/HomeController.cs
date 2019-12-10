using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public static List<Course> _courses = new List<Course>()
        { new Course() { Title = "physics", CourseCode = "bse21 ",},
          new Course() { Title = "Math", CourseCode = "bse26" ,},
        };
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetCourses()
        { return Json(_courses); }
        [HttpPost]
        public JsonResult AddCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                _courses.Add(course);
            }
            return Json("");
        }
      
        
        [HttpPost]
        public JsonResult Delete(string courseCode)
        {
         Course  c=_courses.ToList().Find(x => x.CourseCode.Equals(courseCode));
            _courses.Remove(c);
            return Json(courseCode);
        }

       
        [HttpPost]
        public JsonResult Update(Course course)
        {
            if (ModelState.IsValid)
            { 
                Course c = _courses.ToList().Find(x => x.CourseCode.Equals(course.CourseCode));
                c.Title = course.Title;
            }
            return Json("successful");
         
        }
        public JsonResult getById(string courseCode)
        {
            return Json(_courses.ToList().Find(x => x.CourseCode.Equals(courseCode)), JsonRequestBehavior.AllowGet);
        }

    }
}