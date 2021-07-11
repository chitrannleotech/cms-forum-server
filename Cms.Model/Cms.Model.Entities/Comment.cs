using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Model.Entities
{
    public class Comment : Base
    {
        [Column("id")]
        public Guid Id { get; set; }
        [Column("content")]
        public string Content { get; set; }
        [Column("topic_id")]
        public Guid TopicId { get; set; }
        [Column("user_id")]
        public Guid UserId { get; set; }
        public AppUser AppUser { get; set; }
        public Topic Topic { get; set; }
        public ICollection<Vote> Votes { get; set; }
       
    }
}
