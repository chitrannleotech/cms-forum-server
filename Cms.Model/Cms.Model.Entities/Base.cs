using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Model.Entities
{
    public class Base
    {
        [Column("in_user_id")]
        public Guid CreatedBy { get; set; }
        [Column("up_user_id")]
        public Guid UpdatedBy { get; set; }
        [Column("in_ymd")]
        public DateTime CreatedDate { get; set; }
        [Column("up_ymd")]
        public DateTime UpdatedDate { get; set; }
        [Column("in_time")]
        public DateTime CreatedTime { get; set; }
        [Column("up_time")]
        public DateTime UpdatedTime { get; set; }
        [Column("del_flg")]
        public DateTime DeleteFlag { get; set; }
    }
}
