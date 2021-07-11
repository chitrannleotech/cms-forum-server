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
    public class CommentController : Controller
    {
        private ICommentRepository _reporitory;

        public CommentController(ICommentRepository repository)
        {
            _reporitory = repository;
        }

        [HttpGet("comments")]
        public IActionResult GetComments()
        {
            IEnumerable<Comment> comments = _reporitory.GetAll();
            return Ok(comments);
        }

        [HttpGet("comment/{id}")]
        public IActionResult GetComment(Guid id)
        {
            Comment comment = _reporitory.GetById(id);

            if (comment == null)
            {
                return NotFound();
            }

            return Ok(comment);
        }

        [HttpPost("comment")]
        public IActionResult Post([FromBody] CreateCommentDto comment)
        {
            if (comment == null)
            {
                return BadRequest();
            }

            _reporitory.Create(comment);

            return Ok(comment);
        }

        [HttpPut("comment/{id}")]
        public IActionResult Put(Guid id, [FromBody] UpdateCommentDto comment)
        {
            if (comment == null)
            {
                return BadRequest();
            }

            if (id != comment.Id)
            {
                return NotFound();
            }

            _reporitory.Update(comment);

            return Ok(comment);
        }

        [HttpDelete("comment/{id}")]
        public IActionResult Delete(Guid id)
        {
            Comment comment = _reporitory.GetById(id);

            if (comment == null)
            {
                return BadRequest();
            }

            _reporitory.Delete(comment);

            return Ok(comment);
        }


    }
}
