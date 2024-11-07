using Microsoft.AspNetCore.Identity;

namespace Hubsta.Data
{
    public class SeedRoles
    {
        public static async Task SeedUserRoles(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var _roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                var adminExists = await _roleManager.RoleExistsAsync("admin");
                var userExists = await _roleManager.RoleExistsAsync("user");

                if (!adminExists)
                {
                    await _roleManager.CreateAsync(new IdentityRole("admin"));
                }

                if (!userExists)
                {
                    await _roleManager.CreateAsync(new IdentityRole("user"));
                }
            }
        }
    }
}
