using DataAccess.Abstract;
using Entities.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        public List<Course> courses;
        public CourseDal()
        {
            courses = new List<Course>()
            {
                new Course() {
                    CourseID=1,
                    CourseName="Kurs1",
                    CategoryID=1,
                    InstructorID=1,
                    CourseImage="image1.jpg",
                    CourseDescription="Kurs1 açıklaması"
                },
                new Course()
                {
                    CourseID=2,
                    CourseName="Kurs2",
                    CategoryID=3,
                    InstructorID=1,
                    CourseImage="image2.jpg",
                    CourseDescription="Kurs 2 açıklaması"
                },
            };

        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(int id)
        {
            var deletedCourse = GetById(id);
            courses.Remove(deletedCourse);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course GetById(int id)
        {
            foreach (var course in courses)
            {
                if (course.CourseID == id)
                {
                    return course;
                }
            }
            throw new Exception("Böyle bir kurs bulunmamaktadır.");
        }

        public void PrintAll(List<Course> courses)
        {
            foreach (var course in courses)
            {
                PrintCourse(course);
            }
        }

        public void PrintCourse(Course course)
        {
            
            Console.WriteLine( course.CourseName);
            Console.WriteLine( course.CourseDescription);
            Console.WriteLine( course.CourseImage);
            Console.WriteLine(course.CategoryID);
            Console.WriteLine(course.InstructorID);
            Console.WriteLine();
        }

        public void Update(Course course)
        {
            var updatedCourse = GetById(course.CourseID);
            updatedCourse.CourseName = course.CourseName;
            updatedCourse.CourseDescription = course.CourseDescription;
            updatedCourse.CategoryID = course.CategoryID;
            updatedCourse.CategoryID = course.CategoryID;
            updatedCourse.CourseImage = course.CourseImage;
        }
    }
}
