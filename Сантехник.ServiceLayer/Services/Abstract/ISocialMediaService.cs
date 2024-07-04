﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сантехник.EntityLayer.WebApplication.ViewModels.SocialMediaVM;

namespace Сантехник.ServiceLayer.Services.Abstract
{
    public interface ISocialMediaService
    {
        Task AddCategoryService(SocialMediaAddVM request);
        Task DeleteCategoryAsync(int id);
        Task<List<SocialMediaListVM>> GetAllListAsync();
        Task<SocialMediaUpdateVM> GetCategoryById(int id);
        Task UpdateCategoryAsync(SocialMediaUpdateVM request);
    }
}
