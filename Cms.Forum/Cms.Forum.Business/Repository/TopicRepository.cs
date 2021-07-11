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
    public class TopicRepository : ITopicRepository
    {
        DataDbContext _context;

        public TopicRepository(DataDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Topic> GetAll()
        {
            return _context.Topics.ToList();
        }

        public Topic GetById(Guid id)
        {
            return _context.Topics.FirstOrDefault(c => c.Id == id);
        }

        public void Create(CreateTopicDto createTopicDto)
        {
            Topic topic = new Topic()
            {
                Title = createTopicDto.Title,
                BodyContent = createTopicDto.BodyContent,
                CategoryId = createTopicDto.CategoryId,
                CreatedDate = DateTime.Now,
                CreatedTime = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UpdatedTime = DateTime.Now

            };

            _context.Topics.Add(topic);
            _context.SaveChanges();
        }

        public void Update(UpdateTopicDto updateTopicDto)
        {
            Topic topic = new Topic()
            {
                Id = updateTopicDto.Id,
                Title = updateTopicDto.Title,
                CategoryId = updateTopicDto.CategoryId,
                UpdatedDate = DateTime.Now,
                UpdatedTime = DateTime.Now
            };

            _context.Topics.Update(topic);
            _context.SaveChanges();

        }

        public void Delete(Topic topic)
        {
            _context.Topics.Remove(topic);
            _context.SaveChanges();

        }

    }
}
