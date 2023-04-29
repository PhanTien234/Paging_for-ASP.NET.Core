using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace razorweb2.models{

    public class MyBlogContext : DbContext
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
        }

        public DbSet<Article> articles {get; set;}
    }
}