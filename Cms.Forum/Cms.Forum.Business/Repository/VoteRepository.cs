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
    public class VoteRepository : IVoteRepository
    {
        DataDbContext _context;

        public VoteRepository(DataDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Vote> GetAll()
        {
            return _context.Votes.ToList();
        }

        public Vote GetById(Guid id)
        {
            return _context.Votes.FirstOrDefault(c => c.Id == id);
        }

        public void Create(CreateVoteDto createVoteDto)
        {
            Vote vote = new Vote()
            {
                TopicId = createVoteDto.TopicId,
                CommentId = createVoteDto.CommentId,
                CreatedDate = DateTime.Now,
                CreatedTime = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UpdatedTime = DateTime.Now

            };

            _context.Votes.Add(vote);
            _context.SaveChanges();
        }

        public void Update(UpdateVoteDto updateVoteDto)
        {
            Vote vote = new Vote()
            {
                TopicId = updateVoteDto.TopicId,
                CommentId = updateVoteDto.CommentId,
                UpdatedDate = DateTime.Now,
                UpdatedTime = DateTime.Now
            };

            _context.Votes.Update(vote);
            _context.SaveChanges();

        }

        public void Delete(Vote vote)
        {
            _context.Votes.Remove(vote);
            _context.SaveChanges();

        }

    }
}
