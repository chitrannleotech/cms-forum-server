using Cms.Forum.Dtos;
using Cms.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Forum.Infrastructures.Interface
{
    public interface ICommentRepository
    {
        public void Create(CreateCommentDto comment);

        public void Update(UpdateCommentDto comment);

        public IEnumerable<Comment> GetAll();

        public Comment GetById(Guid Id);

        public void Delete(Comment comment);
    }
}
