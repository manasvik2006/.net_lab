using StudentWeb_api.Model;
namespace StudentWeb_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();


            builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));



            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            //builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
        

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();


            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
