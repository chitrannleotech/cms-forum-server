using Cms.Forum.Dtos;
using Cms.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Forum.Infrastructures.Interface
{
    public interface IVoteRepository
    {
        public void Create(CreateVoteDto vote);

        public void Update(UpdateVoteDto vote);

        public IEnumerable<Vote> GetAll();

        public Vote GetById(Guid Id);

        public void Delete(Vote vote);
    }
}
