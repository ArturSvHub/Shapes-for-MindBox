using Microsoft.EntityFrameworkCore;

using TestAppForSQLPart.Models;

namespace TestAppForSQLPart
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContextPool<ApplicationContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddAuthorization();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();
           
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapGet("/getquery", async (ApplicationContext context) =>
            {
                var result = from p in context.Products
                             join e in context.Enrollments on p.Id equals e.ProductId
                             into en from enres in en.DefaultIfEmpty()
                             join c in context.Categories on enres.CategoryId equals c.Id
                             into cn from cnres in cn.DefaultIfEmpty()
                             select new
                             {
                                 Name = p.Name,
                                 Vendeur = cnres.Name
                            };

                                
                    return result;
            });
            app.Run();
        }
    }
}