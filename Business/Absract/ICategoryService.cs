using Entities.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Delete(int id);
        void Update(Category category);
        public List<Category> GetAll();
        public Category GetById(int id);
        public void PrintAll(List<Category> categories);
        void PrintCategory(Category category);
    }
}
