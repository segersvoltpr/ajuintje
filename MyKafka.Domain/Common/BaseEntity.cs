﻿using System;

namespace MyKafka.Domain.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
