﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сантехник.EntityLayer.Identity.ViewModels;
using Сантехник.ServiceLayer.Messages.Identity;
using Сантехник.ServiceLayer.Messages.WebApplication;

namespace Сантехник.ServiceLayer.FluentValidation.Identity
{
    public class ForgotPasswordValidation : AbstractValidator<ForgotPasswordVM>
    {
        public ForgotPasswordValidation()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("Email"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("Email"))
                .EmailAddress().WithMessage(IdentityMessages.CheckEmailAddress());
        }
    }
}
