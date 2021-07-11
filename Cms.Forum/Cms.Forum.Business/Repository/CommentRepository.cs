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
    public class CommentRepository : ICommentRepository
    {
        DataDbContext _context;

        public CommentRepository(DataDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Comment> GetAll()
        {
            return _context.Comments.ToList();
        }

        public Comment GetById(Guid id)
        {
            return _context.Comments.FirstOrDefault(c => c.Id == id);
        }

        public void Create(CreateCommentDto createCommentDto)
        {
            Comment comment = new Comment()
            {
                Content = createCommentDto.Content,
                TopicId = createCommentDto.TopicId,
                CreatedDate = DateTime.Now,
                CreatedTime = DateTime.Now,
                UpdatedDate = DateTime.Now,
                UpdatedTime = DateTime.Now

            };

            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public void Update(UpdateCommentDto updateCommentDto)
        {
            Comment comment = new Comment()
            {
                Id = updateCommentDto.Id,
                Content = updateCommentDto.Content,
                TopicId = updateCommentDto.TopicId,
                UpdatedDate = DateTime.Now,
                UpdatedTime = DateTime.Now
            };

            _context.Comments.Update(comment);
            _context.SaveChanges();

        }

        public void Delete(Comment comment)
        {
            _context.Comments.Remove(comment);
            _context.SaveChanges();

        }

    }
}
