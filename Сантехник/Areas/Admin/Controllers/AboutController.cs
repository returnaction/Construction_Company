﻿using Microsoft.AspNetCore.Mvc;
using Сантехник.EntityLayer.WebApplication.ViewModels.AboutVM;
using Сантехник.ServiceLayer.Services.Abstract;

namespace Сантехник.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IActionResult> GetAboutList()
        {
            var aboutList = await _aboutService.GetAllListAsync();
            return View(aboutList);
        }


        public IActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAbout(AboutAddVM request)
        {
            await _aboutService.AddAboutAsync(request);
            return RedirectToAction("GetAboutList", "AboutController", new { Area = ("Admin") });
        }


        public async Task<IActionResult> UpdateAbout(int id)
        {
            var about = await _aboutService.GetAboutById(id);
            return View(about);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(AboutUpdateVM request)
        {
            await _aboutService.UpdateAboutAsync(request);
            return RedirectToAction("GetAboutList", "AboutController", new { Area = ("Admin") });
        }
        

        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _aboutService.DeleteAboutAsync(id);
            return RedirectToAction("GetAboutList", "AboutController", new { Area = ("Admin") });
        }
    }
}
