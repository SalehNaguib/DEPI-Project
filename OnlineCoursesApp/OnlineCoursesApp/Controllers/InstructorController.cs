﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineCoursesApp.BLL.Services;
using OnlineCoursesApp.DAL.Models;
using OnlineCoursesApp.ViewModel;
using System.Linq;
using static OnlineCoursesApp.ViewModel.StudentViewModelForInst;

namespace OnlineCoursesApp.Controllers
{

    public class InstructorController : Controller
    {
        private readonly IService<Instructor> _instructorService;

        public InstructorController(IService<Instructor> instructorService)
        {
            _instructorService = instructorService;
        }

     
        public IActionResult Index(int id)
        {
            var instructor = _instructorService.Query()
                                               .Include(i => i.Courses)
                                               .ThenInclude(c => c.Enrolls) 
                                               .FirstOrDefault(i => i.InstructorId == id);

            if (instructor == null)
            {
                return NotFound();
            }

            var courses = instructor.Courses.Select(course => new CourseViewModelForInst
            {
                CourseId = course.CourseId,
                CourseName = course.Name,
                NumStudents = course.Enrolls.Count,
                Type = course.Type
            }).ToList();

            return View(courses);
        }



        public IActionResult Manage()
        {
            return View();
        }



        public IActionResult Students(int id)
        {
            int courseId = id;

          
            var instructor = _instructorService.Query()
                .Include(i => i.Courses)
                .ThenInclude(c => c.Enrolls)
                .ThenInclude(e => e.Student)
                .FirstOrDefault(i => i.Courses.Any(c => c.CourseId == courseId));

            if (instructor == null)
            {
                return NotFound();
            }

            var course = instructor.Courses.FirstOrDefault(c => c.CourseId == courseId);

            if (course == null)
            {
                return NotFound();
            }

            var students = course.Enrolls.Select(e => new StudentViewModelForInst
            {
                StudentId = e.Student.StudentId,
                StudentName = e.Student.Name,
                Progress = e.Progress ?? 0
            }).ToList();

            ViewData["CourseName"] = course.Name;
            return View(students);
        }




    }
}
