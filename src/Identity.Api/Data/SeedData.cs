namespace Identity.Api.Data
{
    public static class Seeder
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            var roleList = new List<IdentityRole>
            {
                new IdentityRole(RolesConstant.Guest),
                new IdentityRole(RolesConstant.Customer),
                new IdentityRole(RolesConstant.Admin),
                new IdentityRole(RolesConstant.Seller),
            };

            modelBuilder.Entity<IdentityRole>()
                .HasData(roleList);
        }
    }
}
