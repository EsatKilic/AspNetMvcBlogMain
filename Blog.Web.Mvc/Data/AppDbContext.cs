using Blog.Web.Mvc.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Mvc.Data

{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // N - N Relationship
            modelBuilder.Entity<Post>()
                .HasMany(e => e.Categories)
                .WithMany(e => e.Posts)
                .UsingEntity("CategoryPosts");

            //.UsingEntity(
            //    "CategoryPosts",
            //    r => r.HasOne(typeof(Post)).WithMany().HasForeignKey("PostId").HasPrincipalKey(nameof(Post.Id)),
            //    l => l.HasOne(typeof(Category)).WithMany().HasForeignKey("CategoryId").HasPrincipalKey(nameof(Category.Id)),
            //    j => j.HasKey("CategoryId", "PostId"));

            DbSeed.SeedDatas(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}