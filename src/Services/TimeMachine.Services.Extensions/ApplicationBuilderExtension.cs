namespace TimeMachine.Services.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    using System;
    using System.Linq;
    using System.Threading.Tasks;

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

                CreateRolesAndSeedAdminAndUser(userManager, roleManager);
                CreateStories(userManager);
            }

            return app;
        }

        private static void CreateRolesAndSeedAdminAndUser(UserManager<TimeMachineUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            Task.Run(async () =>
            {
                // Create Roles
                var adminRole = UserRoles.Admin.ToString();
                var adminRoleExists = await roleManager.RoleExistsAsync(adminRole);

                if (!adminRoleExists)
                {
                    await roleManager.CreateAsync(new IdentityRole
                    {
                        Name = adminRole
                    });
                }

                var userRole = UserRoles.User.ToString();
                var userRoleExists = await roleManager.RoleExistsAsync(UserRoles.User.ToString());

                if (!userRoleExists)
                {
                    await roleManager.CreateAsync(new IdentityRole
                    {
                        Name = userRole
                    });
                }

                if (!userManager.Users.Any())
                {
                    // Create Admin
                    var adminUser = new TimeMachineUser
                    {
                        UserName = Constants.AdminEmail,
                        Email = Constants.AdminEmail,
                        IsProfilePrivate = true
                    };

                    await userManager.CreateAsync(adminUser, Constants.AdminPassword);
                    await userManager.AddToRoleAsync(adminUser, adminRole);

                    // Create User
                    var userUser = new TimeMachineUser
                    {
                        UserName = Constants.UserEmail,
                        Email = Constants.UserEmail,
                        FullName = Constants.UserFullName,
                        BirthDate = DateTime.Parse(Constants.UserBirthDate),
                        IsProfilePrivate = false

                    };

                    await userManager.CreateAsync(userUser, Constants.UserPassword);
                    await userManager.AddToRoleAsync(userUser, userRole);
                }

            }).Wait();
        }

        private static void CreateStories(UserManager<TimeMachineUser> userManager)
        {

        }
    }
}
