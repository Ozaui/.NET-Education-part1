using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using basics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

//course
namespace basics.Controllers;
public class CourseController : Controller
{
    //course/index
    public IActionResult Index()
    {
        var course = new Course();

        course.Id = 1;
        course.Title = "Aspnet core course";
        course.Description = "Good education";
        course.Image = "1.jpg";

        return View(course);//Farklı bir sayfaya yönlendirme istersek view içerisine string olarak yazmalıyız
    }
    //course/list
    public IActionResult List()
    {
        var courses = new List<Course>()
        {
            new Course() {
                Id = 1,
                Title = "Course1",
                Description = "Description1",
                Image = "1.jpg"
                },
            new Course() {
                Id = 2,
                Title = "Course2",
                Description = "Description2",
                Image = "1.jpg"
                },
            new Course() {
                Id = 3,
                Title = "Course3",
                Description = "Description3",
                Image = "1.jpg"
                },
            new Course() {
                Id = 4,
                Title = "Course4",
                Description = "Description4",
                Image = "1.jpg"
                },
            new Course() {
                Id = 5,
                Title = "Course5",
                Description = "Description5",
                Image = "1.jpg"
                }
        };
        return View(courses);
    }
}