using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Migrations;
using WebApplication1.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebApplication1.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        //private readonly String connectionstring=String.Empty;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        //public AppDbContext(IConfiguration configuration)
        //{
        //    connectionstring = configuration.GetConnectionString("LocalConnection");
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //Fetching from Connection string
        //    optionsBuilder.UseSqlServer(connectionstring);
        //    //Local db
        //    //optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=ProductDb;");
        //    //Azure DB
        //    //optionsBuilder.UseSqlServer(@"Server=tcp:azuresqldbak1.database.windows.net,1433;Initial Catalog=ProductAppAzureDb;Persist Security Info=False;User ID=sqladminak;Password=SQLpassword1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


        //}

    }
}
