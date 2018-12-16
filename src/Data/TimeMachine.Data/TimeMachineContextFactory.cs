using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System.IO;
using TimeMachine.Web.Models;

namespace MyProject
{
    public class TimeMachineContextFactory : IDesignTimeDbContextFactory<TimeMachineContext>
    {
        public TimeMachineContext CreateDbContext(string[] args)
        {
            //var optionsBuilder = new DbContextOptionsBuilder<TimeMachineContext>();
            //optionsBuilder.Use("Data Source=blog.db");

            //return new TimeMachineContext(optionsBuilder.Options);

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var builder = new DbContextOptionsBuilder<TimeMachineContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            // Stop client query evaluation
            builder.ConfigureWarnings(w => w.Throw(RelationalEventId.QueryClientEvaluationWarning));

            return new TimeMachineContext(builder.Options);
        }
    }
}