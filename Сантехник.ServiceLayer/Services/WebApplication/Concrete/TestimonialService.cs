﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сантехник.CoreLayer.Enumerators;
using Сантехник.EntityLayer.WebApplication.Entities;
using Сантехник.EntityLayer.WebApplication.ViewModels.CategoryVM;
using Сантехник.EntityLayer.WebApplication.ViewModels.PortfolioVM;
using Сантехник.EntityLayer.WebApplication.ViewModels.TestimonialVM;
using Сантехник.RepositoryLayer.Repositories.Abstract;
using Сантехник.RepositoryLayer.UnitOfWork.Abstract;
using Сантехник.ServiceLayer.Helpers.Generic.Image;
using Сантехник.ServiceLayer.Services.WebApplication.Abstract;

namespace Сантехник.ServiceLayer.Services.WebApplication.Concrete
{
    public class TestimonialService : ITestimonialService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepositories<Testimonial> _repository;
        private readonly IImageHelper _imageHelper;

        public TestimonialService(IUnitOfWork unitOfWork, IMapper mapper, IImageHelper imageHelper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<Testimonial>();
            _imageHelper = imageHelper;
        }



        public async Task<List<TestimonialListVM>> GetAllListAsync()
        {
            List<TestimonialListVM>? testimonialListVM = await _repository.GetAllEntityList().ProjectTo<TestimonialListVM>(_mapper.ConfigurationProvider).ToListAsync();
            return testimonialListVM;
        }

        public async Task<TestimonialUpdateVM> GetTestimonialById(int id)
        {
            TestimonialUpdateVM? testimonial = await _repository.Where(x => x.Id == id).ProjectTo<TestimonialUpdateVM>(_mapper.ConfigurationProvider).SingleAsync();
            return testimonial;
        }

        public async Task AddTestimonialService(TestimonialAddVM request)
        {
            var imageResult = await _imageHelper.ImageUpload(request.Photo, ImageType.testimonial, null);

            if (imageResult.Error != null)
            {
                return;
            }

            request.FileName = imageResult.Filename!;
            request.FileType = imageResult.FileType!;

            Testimonial? testimonial = _mapper.Map<Testimonial>(request);
            await _repository.AddEntityAsync(testimonial);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateTestimonialAsync(TestimonialUpdateVM request)
        {
            var imageResult = await _imageHelper.ImageUpload(request.Photo, ImageType.testimonial, null);

            if (imageResult.Error != null)
            {
                return;
            }

            request.FileName = imageResult.Filename!;
            request.FileType = imageResult.FileType!;

            Testimonial? testimonial = _mapper.Map<Testimonial>(request);
            _repository.UpdateEntity(testimonial);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteTestimonialAsync(int id)
        {
            Testimonial? testimonial = await _repository.GetEntityByIdAsync(id);
            _repository.DeleteEntity(testimonial);
            await _unitOfWork.CommitAsync();

            _imageHelper.DeleteImage(testimonial.FileName);
        }

        // UI Service methods

        public async Task<List<TestimonialListForUI>> GetAllListForUIAsync()
        {
            var testimonialListForUI = await _repository.GetAllEntityList().ProjectTo<TestimonialListForUI>(_mapper.ConfigurationProvider).ToListAsync();
            return testimonialListForUI;
        }

    }
}
