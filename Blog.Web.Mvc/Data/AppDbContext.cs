using Blog.Web.Mvc.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Blog.Web.Mvc.Data

{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryPost> CategoryPosts { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<User> Users { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    string connectionString = "Server=(localdb)\\MSSQLLocalDb; Database=PostDb;";
        //    builder.UseSqlServer(connectionString);
        //    base.OnConfiguring(builder);

        //}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var posts = new List<Post>();
            //for (int i = 1; i <= 100; i++)
            //{
            //    posts.Add(new Post
            //    {
            //        Id = i,
            //        Content = "Content " + i,
            //        CreatedAt = DateTime.Now,
            //        CreatedBy = "cemg"
            //    });
            //}
            //modelBuilder.Entity<Post>().HasData(posts);

            DbSeed.SeedDatas(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
