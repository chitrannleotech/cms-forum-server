﻿using Cms.Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Forum.Dtos
{
    public class CreateTopicDto
    {
        public string Title { get; set; }
        public string BodyContent { get; set; }
        public int CategoryId { get; set; }
    }
}
