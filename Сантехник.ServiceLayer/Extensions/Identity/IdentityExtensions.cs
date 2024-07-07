﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сантехник.EntityLayer.Identity;
using Сантехник.RepositoryLayer.Context;

namespace Сантехник.ServiceLayer.Extensions.Identity
{
    public static class IdentityExtensions
    {
        public static IServiceCollection LoadIdentityExtensions(this IServiceCollection services)
        {

            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 10;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredUniqueChars = 2;
                options.Password.RequireDigit = true;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
                options.Lockout.MaxFailedAccessAttempts = 15;
            })
                .AddRoleManager<RoleManager<AppRole>>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                var newCookie = new CookieBuilder();
                newCookie.Name = "PlumbingCompany";
                options.LoginPath = new PathString("/Authentication/Login");  // add thos later
                options.LogoutPath = new PathString("/Authentication/Logout");// add thos later
                options.AccessDeniedPath = new PathString("/Authentication/AccessDenied");// add thos later
                options.Cookie = newCookie;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60); // cooking expriration time
            });

            return services;
        }
    }
}
