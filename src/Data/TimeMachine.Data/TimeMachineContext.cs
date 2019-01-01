namespace TimeMachine.Web.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using TimeMachine.Data.Models;
    using TimeMachine.Data.Models.Posts;
    using TimeMachine.Web.Areas.Identity.Data;

    public class TimeMachineContext : IdentityDbContext<TimeMachineUser, IdentityRole, string>
    {
        public TimeMachineContext(DbContextOptions<TimeMachineContext> options)
            :  base(options)
        {
        }

        public DbSet<ReaderProfile> ReaderProfiles { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<FamillyTree> FamillyTrees { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
