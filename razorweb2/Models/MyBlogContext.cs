using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace razorweb2.models{
    //razorweb2.models.Article

    public class MyBlogContext : IdentityDbContext<IdentityUser>
    {
        public MyBlogContext(DbContextOptions<MyBlogContext> options) : base(options)
        {
            //..
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuider){
            base.OnModelCreating(modelBuider);

            // foreach (var entityType in modelBuider.Model.GetEntityTypes()){
            //     var tableName = entityType.GetTableName();
            //     if (tableName.StartsWith("AspNet"))
            //     {
            //         entityType.SetTableName(tableName.Substring(6));
            //     }
            // }
        }

        public DbSet<Article> articles {get; set;}
    }
}