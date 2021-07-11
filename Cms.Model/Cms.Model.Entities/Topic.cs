using Cms.Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Model.Entities
{
    public class Topic : Base
    {
        [Column("id")]
        public Guid Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("body_content")]
        public string BodyContent { get; set; }
        [Column("category_id")]
        public int CategoryId { get; set; }
        [Column("topic_status")]
        public TopicStatus TopicStatus { get; set; }
        public Guid UserId { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Vote> Votes { get; set; }
        public AppUser AppUser { get; set; }

    }
}
