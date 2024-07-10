﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сантехник.EntityLayer.WebApplication.ViewModels.SocialMediaVM;

namespace Сантехник.EntityLayer.WebApplication.ViewModels.AboutVM
{
    public class AboutListForUI 
    {
        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Clients { get; set; }
        public int Projects { get; set; }
        public int HardWorkers { get; set; }
        public int HoursOfSupport { get; set; }

        public string FileName { get; set; } = null!;
       
        public SocialMediaListVM SocialMedia { get; set; } = null!;
    }
}
