﻿using Entities.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absract
{
    public interface ICourseService
    {
        void Add(Course course);
        void Delete(int id);
        void Update(Course course);
        public List<Course> GetAll();
        public Course GetById(int id);
        public void PrintAll(List<Course> courses);
        void PrintCourse(Course course);
    }
}
