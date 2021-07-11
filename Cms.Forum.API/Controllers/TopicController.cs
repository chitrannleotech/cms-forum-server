using Cms.Forum.Dtos;
using Cms.Forum.Infrastructures.Interface;
using Cms.Model.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.Forum.API.Controllers
{
    public class TopicController : Controller
    {
        private ITopicRepository _reporitory;

        public TopicController(ITopicRepository repository)
        {
            _reporitory = repository;
        }

        [HttpGet("topics")]
        public IActionResult GetTopics()
        {
            IEnumerable<Topic> topics = _reporitory.GetAll();
            return Ok(topics);
        }

        [HttpGet("topic/{id}")]
        public IActionResult GetTopic(Guid id)
        {
            Topic topic = _reporitory.GetById(id);

            if (topic == null)
            {
                return NotFound();
            }

            return Ok(topic);
        }

        [HttpPost("topic")]
        public IActionResult Post([FromBody] CreateTopicDto topic)
        {
            if (topic == null)
            {
                return BadRequest();
            }

            _reporitory.Create(topic);

            return Ok(topic);
        }

        [HttpPut("topic/{id}")]
        public IActionResult Put(Guid id, [FromBody] UpdateTopicDto topic)
        {
            if (topic == null)
            {
                return BadRequest();
            }

            if (id != topic.Id)
            {
                return NotFound();
            }

            _reporitory.Update(topic);

            return Ok(topic);
        }

        [HttpDelete("topic/{id}")]
        public IActionResult Delete(Guid id)
        {
            Topic topic = _reporitory.GetById(id);

            if (topic == null)
            {
                return BadRequest();
            }

            _reporitory.Delete(topic);

            return Ok(topic);
        }
    }
}
