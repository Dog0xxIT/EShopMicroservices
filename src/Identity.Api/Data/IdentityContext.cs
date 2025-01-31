﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Identity.Api.Data
{
    /// <remarks>
    /// Add migrations using the following command inside the 'EShop.Infrastructure' project directory:
    ///  dotnet ef migrations add --startup-project ..\EShop.Presentation\EShop.Api\EShop.Api.csproj --context EShopDbContext [migration-name]
    ///
    /// Remove migrations
    /// dotnet ef migrations remove --startup-project ..\EShop.Presentation\EShop.Api\EShop.Api.csproj
    ///
    /// 
    /// Update database
    /// dotnet ef database update --startup-project ..\EShop.Presentation\EShop.Api\EShop.Api.csproj
    ///
    /// </remarks>
    /// 
    public class IdentityContext : IdentityDbContext<User>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.SeedData();
        }
    }
}
