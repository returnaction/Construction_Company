﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сантехник.EntityLayer.WebApplication.ViewModels.PortfolioVM;

namespace Сантехник.ServiceLayer.Services.Abstract
{
    public interface IPortfolioService
    {
        Task AddCategoryService(PortfolioAddVM request);
        Task DeleteCategoryAsync(int id);
        Task<List<PortfolioListVM>> GetAllListAsync();
        Task<PortfolioUpdateVM> GetCategoryById(int id);
        Task UpdateCategoryAsync(PortfolioUpdateVM request);
    }
}
