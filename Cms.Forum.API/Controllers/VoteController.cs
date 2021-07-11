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
    public class VoteController : Controller
    {
        private IVoteRepository _reporitory;

        public VoteController(IVoteRepository repository)
        {
            _reporitory = repository;
        }

        [HttpGet("votes")]
        public IActionResult GetVotes()
        {
            IEnumerable<Vote> votes = _reporitory.GetAll();
            return Ok(votes);
        }

        [HttpGet("vote/{id}")]
        public IActionResult GetVote(Guid id)
        {
            Vote vote = _reporitory.GetById(id);

            if (vote == null)
            {
                return NotFound();
            }

            return Ok(vote);
        }

        [HttpPost("vote")]
        public IActionResult Post([FromBody] CreateVoteDto vote)
        {
            if (vote == null)
            {
                return BadRequest();
            }

            _reporitory.Create(vote);

            return Ok(vote);
        }

        [HttpPut("vote/{id}")]
        public IActionResult Put(Guid id, [FromBody] UpdateVoteDto vote)
        {
            if (vote == null)
            {
                return BadRequest();
            }

            if (id != vote.Id)
            {
                return NotFound();
            }

            _reporitory.Update(vote);

            return Ok(vote);
        }

        [HttpDelete("vote/{id}")]
        public IActionResult Delete(Guid id)
        {
            Vote vote = _reporitory.GetById(id);

            if (vote == null)
            {
                return BadRequest();
            }

            _reporitory.Delete(vote);

            return Ok(vote);
        }
    }
}
