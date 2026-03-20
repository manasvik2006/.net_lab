
namespace Oth_demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthentication("MyAuthCookie").AddCookie("MyAuthCookie", options =>
            {
                options.LoginPath = "/Account/Login";


            });

            

            builder.Services.AddControllers();
           

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

           

            app.UseAuthorization();


            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
