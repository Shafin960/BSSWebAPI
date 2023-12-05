using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;

namespace Data.Configurations
{
    public class SeedData
    {
        //public static async Task Initialize(IServiceProvider serviceProvider, string testUserPw)
        //{
        //    using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
        //    {
        //        var user = await EnsureUser(serviceProvider, testUserPw, "admin@contoso.com");
        //        await EnsureRole(serviceProvider, user, "Admin");
        //        SeedDB(context, user);
        //    }
        //}

        //private static async Task<ApplicationUser> EnsureUser(IServiceProvider serviceProvider, string testUserPw, string UserName)
        //{
        //    var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
        //    var user = await userManager.FindByNameAsync(UserName);
        //    if (user == null)
        //    {
        //        user = new ApplicationUser
        //        {
        //            UserName = UserName,
        //            EmailConfirmed = true,
        //            DOB = DateTime.Now,
        //            PhoneNumber = "01723962962",
        //            GenderId = 1,
        //            PhoneNumberConfirmed = true,
        //            TwoFactorEnabled = false,
        //            LockoutEnabled = false,
        //            AccessFailedCount = 0
        //        };
        //        await userManager.CreateAsync(user, testUserPw);
        //    }

        //    if (user == null)
        //    {
        //        throw new Exception("The password is probably not strong enough!");
        //    }

        //    return user;
        //}

        //private static async Task<IdentityResult> EnsureRole(IServiceProvider serviceProvider, ApplicationUser user, string role)
        //{
        //    var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

        //    if (roleManager == null)
        //    {
        //        throw new Exception("roleManager null");
        //    }

        //    IdentityResult IR;
        //    if (!await roleManager.RoleExistsAsync(role))
        //    {
        //        IR = await roleManager.CreateAsync(new IdentityRole(role));
        //    }

        //    var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();

        //    //if (userManager == null)
        //    //{
        //    //    throw new Exception("userManager is null");
        //    //}

        //    var userInfo = await userManager.FindByNameAsync(user.UserName) ?? throw new Exception("The testUserPw password was probably not strong enough!");
        //    IR = await userManager.AddToRoleAsync(user, role);
        //    return IR;
        //}


        //public static void SeedDB(ApplicationDbContext context, ApplicationUser user)
        //{
        //    if (context.Users.Any())
        //    {
        //        return;   // DB has been seeded
        //    }

        //    context.Users.AddRange(user);
        //}
    }
}

    
