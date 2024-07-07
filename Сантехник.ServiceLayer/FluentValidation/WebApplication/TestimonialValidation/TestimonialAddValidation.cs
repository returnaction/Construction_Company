﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сантехник.EntityLayer.WebApplication.ViewModels.TestimonialVM;

namespace Сантехник.ServiceLayer.FluentValidation.WebApplication.TestimonialValidation
{
    public class TestimonialAddValidation : AbstractValidator<TestimonialAddVM>
    {
        public TestimonialAddValidation()
        {
            RuleFor(x => x.Comment)
             .NotNull()
             .NotEmpty()
             .MaximumLength(5000);
            RuleFor(x => x.FullName)
                .NotNull()
                .NotEmpty()
                .MaximumLength(200);
            RuleFor(x => x.Title)
                .NotNull()
                .NotEmpty()
                .MaximumLength(200);
            RuleFor(x => x.FileName)
               .NotNull()
               .NotEmpty();
            RuleFor(x => x.FileType)
                .NotNull()
                .NotEmpty();

            // maybe add photo later
            //RuleFor(x => x.Photo)
            //    .NotNull()
            //    .NotEmpty();
        }
    }
}
