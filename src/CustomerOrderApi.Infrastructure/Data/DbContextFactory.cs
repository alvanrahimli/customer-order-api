using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CustomerOrderApi.Infrastructure.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();
            var connectionString = configuration
                .GetConnectionString("Default");

            var dbContextBuilder = new DbContextOptionsBuilder<AppDbContext>();

            dbContextBuilder.UseNpgsql(connectionString);

            return new AppDbContext(dbContextBuilder.Options);
        }
    }
}