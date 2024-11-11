using CarDealership.Data;
using CarDealership.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("SQLServer");

            builder.Services
                .AddDbContext<DealershipDbContext>(
                    options =>
                    {
                        options.UseSqlServer(connectionString);
                    });

            builder.Services
                .AddDefaultIdentity<ApplicationUser>( cfg =>
                {
                   // cfg.SignIn.RequireConfirmedAccount = true;
                })
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<DealershipDbContext>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }

        //private static void IdentityConfigure(WebApplicationBuilder builder, IdentityOptions cfg)
        //{
        //    cfg.Password.RequireDigit =
        //        builder.Configuration.GetValue<bool>("Identity:Password:RequireDigits");
        //    cfg.Password.RequireLowercase =
        //        builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
        //    cfg.Password.RequireUppercase =
        //        builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
        //    cfg.Password.RequireNonAlphanumeric =
        //        builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumerical");
        //    cfg.Password.RequiredLength =
        //        builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");
        //    cfg.Password.RequiredUniqueChars =
        //        builder.Configuration.GetValue<int>("Identity:Password:RequiredUniqueCharacters");
        //
        //    cfg.SignIn.RequireConfirmedAccount =
        //        builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
        //    cfg.SignIn.RequireConfirmedEmail =
        //        builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedEmail");
        //    cfg.SignIn.RequireConfirmedPhoneNumber =
        //        builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedPhoneNumber");
        //
        //    cfg.User.RequireUniqueEmail =
        //        builder.Configuration.GetValue<bool>("Identity:User:RequireUniqueEmail");
        //}
    }
}
