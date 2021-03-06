﻿using BarkingMad_Identity.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BarkingMad_Identity.Startup))]
namespace BarkingMad_Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        //// In this method we will create default User roles and Admin user for login 
        //private void createRolesandUsers()
        //{
        //    ApplicationDbContext context = new ApplicationDbContext();

        //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        //    var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


        //    // In Startup iam creating first Admin Role and creating a default Admin User  
        //    if (!roleManager.RoleExists("Admin"))
        //    {

        //        // first we create Admin role 
        //        var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //        role.Name = "Admin";
        //        roleManager.Create(role);

        //        //Here we create an Admin super user who will maintain the website                 

        //        var user = new ApplicationUser();
        //        user.UserName = "dana";
        //        user.Email = "dana@gmail.com";

        //        string userPWD = "123456aD!£$%^";

        //        var chkUser = UserManager.Create(user, userPWD);

        //        //Add default User to Role Admin 
        //        if (chkUser.Succeeded)
        //        {
        //            var result1 = UserManager.AddToRole(user.Id, "Admin");

        //        }
        //    }

        //    // creating Creating Manager role  
        //    if (!roleManager.RoleExists("Manager"))
        //    {
        //        var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //        role.Name = "Manager";
        //        roleManager.Create(role);

        //    }

        //    // creating Creating Employee role  
        //    if (!roleManager.RoleExists("Walker"))
        //    {
        //        var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //        role.Name = "Employee";
        //        roleManager.Create(role);

        //    }
        //}
    }
}

