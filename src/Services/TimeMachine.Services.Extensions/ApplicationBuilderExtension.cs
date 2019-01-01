namespace TimeMachine.Services.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TimeMachine.Data.Models;
    using TimeMachine.Services.Constants;
    using TimeMachine.Services.Enums;
    using TimeMachine.Web.Areas.Identity.Data;
    using TimeMachine.Web.Models;

    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseDatabaseMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetRequiredService<TimeMachineContext>().Database.Migrate();
                var userManager = serviceScope.ServiceProvider.GetService<UserManager<TimeMachineUser>>();
                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                var db = serviceScope.ServiceProvider.GetService<TimeMachineContext>();

                //CreateRolesAndSeedAdminAndUser(userManager, roleManager);
                //CreateStories(userManager, db);
            }

            return app;
        }

        //private static void CreateRolesAndSeedAdminAndUser(UserManager<TimeMachineUser> userManager, RoleManager<IdentityRole> roleManager)
        //{
        //    Task.Run(async () =>
        //    {
        //        // Create Roles
        //        var adminRole = UserRoles.Admin.ToString();
        //        var adminRoleExists = await roleManager.RoleExistsAsync(adminRole);

        //        if (!adminRoleExists)
        //        {
        //            await roleManager.CreateAsync(new IdentityRole
        //            {
        //                Name = adminRole
        //            });
        //        }

        //        var userRole = UserRoles.User.ToString();
        //        var userRoleExists = await roleManager.RoleExistsAsync(UserRoles.User.ToString());

        //        if (!userRoleExists)
        //        {
        //            await roleManager.CreateAsync(new IdentityRole
        //            {
        //                Name = userRole
        //            });
        //        }

        //        if (!userManager.Users.Any())
        //        {
        //            // Create Admin
        //            var adminUser = new TimeMachineUser
        //            {
        //                UserName = Constants.AdminEmail,
        //                Email = Constants.AdminEmail,
        //                IsProfilePrivate = true
        //            };

        //            await userManager.CreateAsync(adminUser, Constants.AdminPassword);
        //            await userManager.AddToRoleAsync(adminUser, adminRole);

        //            // Create User
        //            var userUser = new TimeMachineUser
        //            {
        //                UserName = Constants.UserEmail,
        //                Email = Constants.UserEmail,
        //                FullName = Constants.UserFullName,
        //                BirthDate = DateTime.Parse(Constants.UserBirthDate),
        //                IsProfilePrivate = false

        //            };

        //            await userManager.CreateAsync(userUser, Constants.UserPassword);
        //            await userManager.AddToRoleAsync(userUser, userRole);
        //        }

        //    }).Wait();
        //}

        //private static void CreateStories(UserManager<TimeMachineUser> userManager, TimeMachineContext db)
        //{
        //    Task.Run(async () =>
        //    {
        //        var seededFirstUser = db.Users.Skip(1).First();

        //        if (!seededFirstUser.Stories.Any())
        //        {
        //            // Seed Stories to first User
        //            var stories = new List<Story>();
        //            for (int i = 0; i < 10; i++)
        //            {
        //                stories.Add(new Story()
        //                {
        //                    TextContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ac ut consequat semper viverra nam libero justo laoreet. Dolor morbi non arcu risus quis varius quam quisque id. At lectus urna duis convallis convallis. Vitae et leo duis ut. Ipsum dolor sit amet consectetur adipiscing elit ut aliquam. Arcu bibendum at varius vel pharetra. Massa tincidunt dui ut ornare lectus sit amet est. Odio ut sem nulla pharetra diam sit amet. Velit egestas dui id ornare arcu. Risus feugiat in ante metus. Bibendum arcu vitae elementum curabitur vitae nunc sed velit. Gravida dictum fusce ut placerat orci nulla pellentesque dignissim. Etiam sit amet nisl purus in. Vel elit scelerisque mauris pellentesque pulvinar pellentesque. Lacinia at quis risus sed vulputate odio. Et tortor consequat id porta nibh venenatis. Risus commodo viverra maecenas accumsan lacus vel facilisis volutpat.",
        //                    CreatedOn = DateTime.Now,
        //                    UserId = seededFirstUser.Id
        //                });
        //            }

        //            await db.Stories.AddRangeAsync(stories);
        //            await db.SaveChangesAsync();
        //        }

        //    }).Wait();
        //}
    }
}
