using Cms.Forum.Dtos;
using Cms.Forum.Infrastructures.Interface;
using Cms.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.Forum.API.Controllers
{
    
    public class CategoryController : Controller
    {
        private ICategoryRepository _repository;

        public CategoryController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("categories")]
        public IActionResult GetCategories()
        {
            IEnumerable<Category> categories = _repository.GetAll();
            return Ok(categories);
        }

        [HttpGet("category/{id}")]
        public IActionResult GetCategory(int id)
        {
            Category category = _repository.GetById(id);

            if(category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost("category")]
        public IActionResult Post([FromBody] CreateCategoryDto category)
        {
            if(category == null)
            {
                return BadRequest();
            }

            _repository.Create(category);

            return Ok(category);
        }

       [HttpPut("category/{id}")]
       public IActionResult Put(int id, [FromBody] UpdateCategoryDto category)
        {
            if(category == null)
            {
                return BadRequest();
            }
            
            if(id != category.Id)
            {
                return NotFound();
            }

            _repository.Update(category);

            return Ok(category);
        }

        [HttpDelete("category/{id}")]
        public IActionResult Delete(int id)
        {
            Category category = _repository.GetById(id);

            if(category == null)
            {
                return BadRequest();
            }

            _repository.Delete(category);

            return Ok(category);
        }


    }
}
