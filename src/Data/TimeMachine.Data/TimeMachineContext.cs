using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeMachine.Data.Models.UserProfile;
using TimeMachine.Web.Areas.Identity.Data;

namespace TimeMachine.Web.Models
{
    public class TimeMachineContext : IdentityDbContext<TimeMachineUser>
    {
        public TimeMachineContext(DbContextOptions<TimeMachineContext> options)
            : base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Letter> Letters { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
