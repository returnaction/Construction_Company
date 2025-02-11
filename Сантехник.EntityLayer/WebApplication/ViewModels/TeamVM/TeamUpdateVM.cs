﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сантехник.EntityLayer.WebApplication.ViewModels.TeamVM
{
    public class TeamUpdateVM
    {
        public int Id { get; set; }
        public string? UpdateDate { get; set; } // This probably also don't need cuz we can do it in the bottom level when we maping the model

        public byte[] RowVersion { get; set; } = null!;


        public string FullName { get; set; } = null!;
        public string Title { get; set; } = null!;

        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;

        public IFormFile Photo { get; set; } = null!;

        public string? Twitter { get; set; } = null!;
        public string? Linkedin { get; set; } = null!;
        public string? Facebook { get; set; } = null!;
        public string? Instagram { get; set; } = null!;
    }
}
