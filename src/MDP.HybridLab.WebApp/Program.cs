namespace MDP.HybridLab.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // WebApplicationBuilder
            var builder = WebApplication.CreateBuilder(args);
            {
                builder.Services.AddControllersWithViews();
                builder.Services.AddServerSideBlazor();
                builder.Services.AddSingleton<MessageService>();
            }

            // WebApplication
            var app = builder.Build();
            {
                if (!app.Environment.IsDevelopment())
                {
                    app.UseExceptionHandler("/Home/Error");
                    app.UseHsts();
                }

                app.UseHttpsRedirection();
                app.UseStaticFiles();

                app.UseRouting();
                
                app.UseAuthorization();

                app.MapBlazorHub();
                app.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            }

            // Run
            app.Run();
        }
    }
}
