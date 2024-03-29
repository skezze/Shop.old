using Microsoft.EntityFrameworkCore;
using Shop.Database;

namespace Shop.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var services = builder.Services;
            services.AddRazorPages();
            services.AddMvc();
            services.AddDbContext<ApplicationDbContext>(option=>option
                .UseSqlServer(builder.Configuration.GetConnectionString("MyShop")));
            //
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.MapControllers();
            app.UseRouting();
           
            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}