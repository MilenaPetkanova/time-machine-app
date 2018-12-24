using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using TimeMachine.Services.Enums;
using TimeMachine.Web.Areas.Identity.Data;
using TimeMachine.Web.Models;

namespace TimeMachine.Services.Extensions
{
    public static class ApplicationBuilderExtension
    {
        private const string AdminUsername = "AdminUsername";
        private const string AdminEmail = "admin@test.com";
        private const string AdminPassword = "test123";

        private const string UserUsername = "UserUsername";
        private const string UserEmail = "user@test.com";
        private const string UserPassword = "test123";

        public static IApplicationBuilder UseDatabaseMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetRequiredService<TimeMachineContext>().Database.Migrate();
                var userManager = serviceScope.ServiceProvider.GetService<UserManager<TimeMachineUser>>();
                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                var db = serviceScope.ServiceProvider.GetService<TimeMachineContext>();

                CreateAdminAndUser(userManager, roleManager);
                //SeedEvents(db);
            }

            return app;
        }

        //private static void SeedEvents(TimeMachineContext db)
        //{
        //    if (db.Events.Count() != 0)
        //    {
        //        return;
        //    }

        //    var eventsList = new List<Event>();

        //    var eventEntity1 = new Event
        //    {
        //        UUID = "UUID-1",
        //        Name = "Test Name",
        //        Place = "Test Place",
        //        Start = new DateTime(2018, 5, 8),
        //        End = new DateTime(2018, 5, 8),
        //        TotalTickets = 28,
        //        PricePerTicket = 0
        //    };
        //    eventsList.Add(eventEntity1);

        //    var eventEntity2 = new Event
        //    {
        //        UUID = "UUID-2",
        //        Name = "Test Name 2",
        //        Place = "Test Place 2",
        //        Start = new DateTime(2018, 5, 8),
        //        End = new DateTime(2018, 5, 8),
        //        TotalTickets = 28,
        //        PricePerTicket = 100
        //    };
        //    eventsList.Add(eventEntity2);

        //    db.Events.AddRange(eventsList);
        //    db.SaveChanges();
        //}

        private static void CreateAdminAndUser(UserManager<TimeMachineUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            Task.Run(async () =>
            {
                var adminRole = UserRoles.Admin.ToString();
                var adminRoleExists = await roleManager.RoleExistsAsync(adminRole);
                
                if (!adminRoleExists)
                {
                    await roleManager.CreateAsync(new IdentityRole
                    {
                        Name = adminRole
                    });

                    var adminUser = await userManager.FindByNameAsync(AdminUsername);

                    if (adminUser == null)
                    {
                        adminUser = new TimeMachineUser
                        {
                            UserName = AdminUsername,
                            Email = AdminEmail,
                            BirthDate = DateTime.Today
                        };

                        await userManager.CreateAsync(adminUser, AdminPassword);
                        await userManager.AddToRoleAsync(adminUser, adminRole);
                    }
                }

                var userRole = UserRoles.User.ToString();
                var userRoleExists = await roleManager.RoleExistsAsync(UserRoles.User.ToString());

                if (!userRoleExists)
                {
                    await roleManager.CreateAsync(new IdentityRole
                    {
                        Name = userRole
                    });

                    var userUser = await userManager.FindByNameAsync(UserUsername);

                    if (userUser == null)
                    {
                        userUser = new TimeMachineUser
                        {
                            UserName = UserUsername,
                            Email = UserEmail,
                            BirthDate = DateTime.Today
                        };

                        await userManager.CreateAsync(userUser, UserPassword);
                        await userManager.AddToRoleAsync(userUser, userRole);
                    }
                }
            }).Wait();
        }
    }
}
