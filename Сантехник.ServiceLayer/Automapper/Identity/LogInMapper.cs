﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сантехник.EntityLayer.Identity;
using Сантехник.EntityLayer.Identity.ViewModels;

namespace Сантехник.ServiceLayer.Automapper.Identity
{
    public class LogInMapper : Profile
    {
        public LogInMapper()
        {
            CreateMap<AppUser, LogInVM>().ReverseMap();
        }
    }
}
