﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlogApp.Shared.Utilities.Results.ComplexTypes;

namespace MyBlogApp.Shared.Entities.Abstarct
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
    }
}
