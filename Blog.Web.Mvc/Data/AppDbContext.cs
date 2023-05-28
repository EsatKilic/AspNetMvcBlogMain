using Blog.Web.Mvc.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Mvc.Data

{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<CategoryPost> CategoryPosts { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // N - N Relationship Basit
            //modelBuilder.Entity<Post>()
            //    .HasMany(e => e.Categories)
            //    .WithMany(e => e.Posts)
            //    .UsingEntity("CategoryPosts");

            // N - N Relationship Detaylı
            //modelBuilder.Entity<Post>()
            //    .HasMany(e => e.Categories)
            //    .WithMany(e => e.Posts)
            //    .UsingEntity(
            //        "CategoryPosts",
            //        l => l.HasOne(typeof(Category)).WithMany().HasForeignKey("CategoryId").HasPrincipalKey(nameof(Category.Id)),
            //        r => r.HasOne(typeof(Post)).WithMany().HasForeignKey("PostId").HasPrincipalKey(nameof(Post.Id)),
            //        j => j.HasKey("CategoryId", "PostId"));

            // N - N Relationship CategoryPost sınıfı üzerinden
            modelBuilder.Entity<Post>()
               .HasMany(e => e.Categories)
               .WithMany(e => e.Posts)
               .UsingEntity<CategoryPost>(
                   l => l.HasOne<Category>().WithMany().HasForeignKey("CategoryId").HasPrincipalKey(c => c.Id),
                   r => r.HasOne<Post>().WithMany().HasForeignKey("PostId").HasPrincipalKey(p => p.Id),
                   j => j.HasKey(cp => new { cp.CategoryId, cp.PostId }));

            DbSeed.SeedDatas(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}