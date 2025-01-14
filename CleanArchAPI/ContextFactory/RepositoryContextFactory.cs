﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository;

namespace JWTAuthAPI.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            
            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(config.GetConnectionString("sqlConnection"),
                options => options.MigrationsAssembly("JWTAuthAPI"));

            return new RepositoryContext(builder.Options);
        }
    }
}
