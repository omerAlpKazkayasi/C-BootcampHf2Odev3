using Entities.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absract
{
    public interface IInstructorService
    {
        void Add(Instructor instructor);
        void Delete(int id);
        void Update(Instructor instructor);
        public List<Instructor> GetAll();
        public Instructor GetById(int id);
        public void PrintAll(List<Instructor> instructors);
        void PrintInstructor(Instructor instructor);
    }
}
