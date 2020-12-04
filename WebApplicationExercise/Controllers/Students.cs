using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationExercise.Models;

namespace WebApplicationExercise.Controllers
{
    public class Students : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
         {
             new Student{SId=1,SName="Aaryan",DOB=DateTime.Parse("12/05/1998"),SContact=9949484894},
              new Student{SId=2,SName="Shayam",DOB=DateTime.Parse("12/06/1998"),SContact=345353534},
               new Student{SId=3,SName="Priti",DOB=DateTime.Parse("12/04/1998"),SContact=4433434322},
                new Student{SId=4,SName="Jayant",DOB=DateTime.Parse("12/07/1998"),SContact=3242343242},
                 new Student{SId=5,SName="Vineet",DOB=DateTime.Parse("11/05/1998"),SContact=234242342},
         };
            
            ViewBag.message = students.Count();
            return View(students);

        }
    }
}
