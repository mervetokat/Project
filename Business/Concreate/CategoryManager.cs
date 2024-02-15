using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public List<Category> GetAllByCategoryId(int id)
        {
            
            return _categoryDal.GetAll(p => p.CategoryId == id);
        }
    }
}
