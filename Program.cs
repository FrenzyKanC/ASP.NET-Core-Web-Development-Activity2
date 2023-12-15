namespace ASP.NET_Core_Web_Development_Activity2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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

            app.UseAuthorization();

            // Startup.cs ist hier rein gewandert --> builder.Services nutzen
            app.MapControllerRoute(
                name: "default",
                // erster / zweiter / dritter / defaults bei dem root-link
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
