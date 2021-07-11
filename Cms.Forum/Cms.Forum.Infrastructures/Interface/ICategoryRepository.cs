using Cms.Forum.Dtos;
using Cms.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Forum.Infrastructures.Interface
{
    public interface ICategoryRepository
    {
        public void Create(CreateCategoryDto category);

        public void Update(UpdateCategoryDto category);

        public IEnumerable<Category> GetAll();

        public Category GetById(int Id);

        public void Delete(Category category);

    }
}
