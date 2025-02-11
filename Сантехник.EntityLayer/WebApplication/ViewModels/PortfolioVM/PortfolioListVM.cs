﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сантехник.EntityLayer.WebApplication.Entities;
using Сантехник.EntityLayer.WebApplication.ViewModels.CategoryVM;

namespace Сантехник.EntityLayer.WebApplication.ViewModels.PortfolioVM
{
    public class PortfolioListVM
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdateDate { get; set; }


        public string Title { get; set; } = null!;

        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;

        public int CategoryId { get; set; }
        public CategoryListVM Category { get; set; } = null!;
    }
}
