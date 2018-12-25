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
    public class TimeMachineContext : IdentityDbContext<TimeMachineUser, IdentityRole, string>
    {
        public TimeMachineContext(DbContextOptions<TimeMachineContext> options)
            :  base(options)
        {
        }

        public DbSet<Story> Stories { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Letter> Letters { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}
    }
}
