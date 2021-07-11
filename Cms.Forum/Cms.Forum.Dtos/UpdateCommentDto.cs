using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Forum.Dtos
{
    public class UpdateCommentDto
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid TopicId { get; set; }
    }
}
