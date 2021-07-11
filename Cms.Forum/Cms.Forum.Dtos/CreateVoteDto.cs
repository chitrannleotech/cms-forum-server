using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Forum.Dtos
{
    public class CreateVoteDto
    {
        public Guid TopicId { get; set; }
        public Guid CommentId { get; set; }

    }
}
