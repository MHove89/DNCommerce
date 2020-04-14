﻿using System;

namespace DNCommerce.Domain.Entities
{
    public abstract class BaseEntitiy
    {
        public string CreatedBy { get; set; }

        public DateTime Created { get; set; }
        
        public string LastModifiedBy { get; set; }
        
        public DateTime? LastModified { get; set; }
    }
}
