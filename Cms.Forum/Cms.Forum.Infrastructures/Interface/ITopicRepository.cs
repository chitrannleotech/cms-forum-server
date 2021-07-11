using Cms.Forum.Dtos;
using Cms.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Forum.Infrastructures.Interface
{
    public interface ITopicRepository
    {
        public void Create(CreateTopicDto topic);

        public void Update(UpdateTopicDto topic);

        public IEnumerable<Topic> GetAll();

        public Topic GetById(Guid Id);

        public void Delete(Topic topic);
    }
}
