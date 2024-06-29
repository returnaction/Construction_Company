﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Сантехник.CoreLayer.BaseEntity;

namespace Сантехник.EntityLayer.WebApplication.Entities
{
    public class About : BaseEntity
    {
        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Clients { get; set; } 
        public int Projects { get; set; } 
        public int HardWorkers { get; set; } 
        public int HoursOfSupport { get; set; }

        public string FileName { get; set; } = null!;
        public string TyleType { get; set; } = null!;

        public int SocialMediaId { get; set; }
        public SocialMedia SocialMedia { get; set; } = null!;
    }
}
