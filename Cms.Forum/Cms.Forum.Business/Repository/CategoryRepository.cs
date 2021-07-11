using Cms.Forum.Dtos;
using Cms.Forum.Infrastructures.Interface;
using Cms.Model.Context;
using Cms.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Forum.Business.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        DataDbContext _context;
        
        public CategoryRepository(DataDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Category.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Category.FirstOrDefault(c => c.Id == id);
        }

        public void Create(CreateCategoryDto createCategoryDto)
        {
            Category category = new Category()
            {
                Name = createCategoryDto.Name,
                CreatedDate = DateTime.Now,
                CreatedTime = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UpdatedTime = DateTime.Now
                
            };

            _context.Category.Add(category);
            _context.SaveChanges();
        }

        public void Update(UpdateCategoryDto updateCategoryDto)
        {
            Category category = new Category()
            {
                Id = updateCategoryDto.Id,
                Name = updateCategoryDto.Name,
                UpdatedDate = DateTime.Now,
                UpdatedTime = DateTime.Now
            };

            _context.Category.Update(category);
            _context.SaveChanges();

        }

        public void Delete(Category category)
        {
            _context.Category.Remove(category);
            _context.SaveChanges();

        }

    }
}
