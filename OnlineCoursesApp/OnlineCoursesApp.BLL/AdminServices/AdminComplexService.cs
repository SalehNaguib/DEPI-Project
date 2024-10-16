﻿using Microsoft.EntityFrameworkCore;
using OnlineCoursesApp.BLL.Services;
using OnlineCoursesApp.DAL.Models;
using System.Linq;

public class AdminComplexService : IAdminComplexService
{
    private readonly IService<Course> _courseService;
    private readonly IService<Student> _studentService;
    private readonly IService<Instructor> _instructorService;

    public AdminComplexService(IService<Course> courseService, IService<Student> studentService, IService<Instructor> instructorService)
    {
        _courseService = courseService;
        _studentService = studentService;
        _instructorService = instructorService;
    }

    // Manage New and Current Courses
    public IQueryable<Course> GetNewCourses()
    {
        return _courseService.Query().Where(c => c.CourseStatus == CourseStatus.UnderReview);
    }
    public IQueryable<Course> GetAllCourses() => _courseService.Query().Where(c => c.CourseStatus != CourseStatus.UnderReview);
    public Course GetCourseById(int id)
    {
        return _courseService.Query()
                             .Include(c => c.Students)  // Make sure to include the Students collection
                             .FirstOrDefault(c => c.CourseId == id);
    }

    public void ApproveCourse(int courseId)
    {
        var course = _courseService.GetById(courseId);
        if (course != null)
        {
            course.CourseStatus = CourseStatus.Approved;  // Set status to Approved (1)
            _courseService.Update(course);
        }
    }


    public void RejectCourse(int courseId)
    {
        var course = _courseService.GetById(courseId);
        if (course != null)
        {
            course.CourseStatus = CourseStatus.Rejected;  // Set status to Rejected (0)
            _courseService.Update(course);
        }
    }


    // Manage Students
    public IQueryable<Student> GetAllStudents() => _studentService.Query();
    public Student GetStudentById(int id) => _studentService.GetById(id);
    public void DeleteStudent(int studentId) => _studentService.Delete(studentId);

    // Manage Instructors
    public IQueryable<Instructor> GetAllInstructors() => _instructorService.Query();
    public Instructor GetInstructorById(int id) => _instructorService.GetById(id);

    // Updated DeleteInstructor method with course-check logic
    public void DeleteInstructor(int instructorId)
    {
        // Check if the instructor has any courses assigned
        var hasCourses = _courseService.Query().Include(i => i.Instructor).Any(c => c.Instructor.InstructorId == instructorId);

        if (hasCourses)
        {
            // If there are courses, prevent deletion and throw an exception
            throw new InvalidOperationException("Cannot delete an instructor with active courses.");
        }

        // If no courses exist for the instructor, delete the instructor
        _instructorService.Delete(instructorId);
    }
}
