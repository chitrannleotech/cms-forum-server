using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Model.Entities
{
    public class Vote : Base
    {
        [Column("id")]
        public Guid Id { get; set; }
        [Column("topic_id")]
        public Guid TopicId { get; set; }
        [Column("comment_id")]
        public Guid CommentId { get; set; }
        [Column("user_id")]
        public Guid UserId { get; set; }
        public Topic Topic { get; set; }
        public Comment Comment { get; set; }
        public AppUser AppUser { get; set; }
    }
}
