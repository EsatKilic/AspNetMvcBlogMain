using Blog.Web.Mvc.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Mvc.Data
{
    public class DbSeed
    {
        public static void SeedDatas(ModelBuilder modelBuilder)
        {
            SeedCategories(modelBuilder);
            SeedPosts(modelBuilder);
            SeedCategoryPosts(modelBuilder);
            SeedPages(modelBuilder);
            SeedPostImages(modelBuilder);
            SeedUsers(modelBuilder);
            SeedSettings(modelBuilder);
        }

        public static void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new List<Category>
            {
                new() {Id = 1 , Name = "Innovation" , Description="find new things and discover the world", Slug="innovation"},
                new() {Id = 2 , Name = "Improvements" , Description="learn develops", Slug="improvements"},
                new() {Id = 3 , Name = "Software" , Description="guide technological developments", Slug="software"},
                new() {Id = 4 , Name = "Software Languages" , Description="c# and JS", Slug="software languages"},
                new() {Id = 5 , Name = "Social" , Description="use social media and effect our lifes", Slug="social"},
                new() {Id = 6 , Name = "Trends" , Description="popular things", Slug="trends"},
                new() {Id = 7 , Name = "Economy" , Description="money talks", Slug="economy"},
                new() {Id = 8 , Name = "Hobbies" , Description="enjoy your time", Slug="hobbies"},
            });

        }

        public static void SeedCategoryPosts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryPost>().HasData(new List<CategoryPost>
            {
                new() { CategoryId = 1, PostId = 1 },
                new() { CategoryId = 2, PostId = 2 },
                new() { CategoryId = 3, PostId = 3 },
                new() { CategoryId = 4, PostId = 4 }
            });
        }

        public static void SeedPosts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(new List<Post>
            {
                new() {Id = 1 , UserId = 1, Slug = "innovation-1", Title= "Innovation And News" , Content="Lorem ipsum dolor sit amet", IsFeatured = true },
                new() {Id = 2 , UserId = 1, Slug = "innovation-2", Title= "My Discovers" , Content="Richard McClintock, a Latin professor at Hampden-Sydney College", IsFeatured = true },
                new() {Id = 3 , UserId = 2, Slug = "software-1", Title= "Software's benefits" , Content="Sed ut perspiciatis unde ", IsFeatured = true },
                new() {Id = 4 , UserId = 2, Slug = "software-2", Title= "Learn Tech" , Content="All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary ", IsFeatured = true },
                new() {Id = 5 , UserId = 3, Slug = "social-1", Title ="Social Media" , Content="But I must explain to you  ", IsFeatured = true },
                new() {Id = 6 , UserId = 3, Slug = "social-2", Title ="Social Pressure" , Content="Many desktop publishing packages  ", IsFeatured = true },
                new() {Id = 7 , UserId = 4, Slug = "trends-1", Title ="Trends Habbits" , Content="At vero eos et accusamus et ", IsFeatured = true },
                new() {Id = 8 , UserId = 4, Slug = "trends-2", Title ="Run The Trends" , Content="Aldus PageMaker including versions of Lorem Ipsum ", IsFeatured = true },
                new() {Id = 9 , UserId = 5, Slug = "economy", Title ="How Can I Earn Money Easyly?" , Content="Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime ", IsFeatured = true },
                new() {Id = 10 , UserId = 6, Slug = "hobbies", Title ="Just Do Things What You Want" , Content="every pleasure is to be welcomed and every pain avoided.  ", IsFeatured = true },
            });
        }

        public static void SeedPostImages(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostImage>().HasData(new List<PostImage>
            {
               new() { Id = 1, PostId = 1, ImagePath = "", },
                new() { Id = 2, PostId = 2, ImagePath = "", },
                new() { Id = 3, PostId = 3, ImagePath = "", },
                new() { Id = 4, PostId = 4, ImagePath = "", },
            });

        }

        public static void SeedPages(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Page>().HasData(new List<Page>
            {
                new() {Id = 1 , Title = "Discuss" , Context= " text of the printing and typesetting industry." , IsActive=true },
                new() {Id = 2 , Title = "Write" , Context= " dummy  typesetting industry." , IsActive=true },
                new() {Id = 3 , Title = "About Me" , Context= "Lorem Ipsum is simply dummy text of the printing and typesetting industry." , IsActive=true },
               
            });

            //var pages = new List<Page>();
            //for (int i = 1; i <= 100; i++)
            //{
            //    pages.Add(new Page
            //    {
            //        Id = i,
            //        Title = "Title " + i,
            //        Context = "Context " + i,
            //        IsActive = true,
            //    });
            //}
            //modelBuilder.Entity<Page>().HasData(pages);
        }

        public static void SeedPostComments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostComment>().HasData(new List<PostComment>
            {
                new() { Id = 1 ,PostId=1, UserId = 1 , Comment = "I like this post", IsActive = true  },
                new() { Id = 2 ,PostId=2, UserId = 2 , Comment = "I like this post", IsActive = true },
                new() { Id = 3 ,PostId=3, UserId = 3 , Comment = "I like this post", IsActive = true },
                new() { Id = 4 ,PostId=4, UserId = 4 , Comment = "I like this post", IsActive = true },
                new() { Id = 5 ,PostId=5, UserId = 5 , Comment = "I like this post", IsActive = true },
                new() { Id = 6 ,PostId=6, UserId = 6 , Comment = "I do not like this post", IsActive = true },
                new() { Id = 7 ,PostId=7, UserId = 2 , Comment = "I do not like this post", IsActive = true },
                new() { Id = 8 ,PostId=8, UserId = 4 , Comment = "I like this post", IsActive = true },
                new() { Id = 9 ,PostId=9, UserId = 2 , Comment = "I do not like this post", IsActive = true },
                new() { Id = 10 ,PostId=10, UserId = 1 , Comment = "I like this post", IsActive = true },
            });
        }

        public static void SeedSettings(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setting>().HasData(new List<Setting>
            {
                new() { Id = 1 , UserId = 1 , Name = "Tema", Value = "Dark"  },
                new() { Id = 2 , UserId = 2 , Name = "Tema", Value = "Light" },
                new() { Id = 3 , UserId = 3 , Name = "Tema", Value = "Light" },
                new() { Id = 4 , UserId = 4 , Name = "Tema", Value = "Dark" },
                new() { Id = 5 , UserId = 5 , Name = "Tema", Value = "Blue" },
                new() { Id = 6 , UserId = 5 , Name = "Tema", Value = "Dark" },
            });
        }

        public static void SeedUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new List<User>
            {
                new() { Id = 1 , Email = "esat@gmail.com", Password ="123", Name= "esat", City="Ankara", Phone = "+90532" },
                new() { Id = 2 , Email = "ali@gmail.com", Password ="456", Name= "ali", City="Mersin", Phone = "+90536" },
                new() { Id = 3 , Email = "umit@gmail.com", Password ="789", Name ="ümit", City="İstanbul", Phone = "+90505" },
                new() { Id = 4 , Email = "cem@gmail.com", Password ="012", Name ="cem", City="Ankara", Phone = "+90542" },
                new() { Id = 5 , Email = "onur@gmail.com", Password ="014", Name ="onur", City="İzmir", Phone = "+90542" },
                new() { Id = 6 , Email = "kerem@gmail.com", Password ="062", Name ="kerem", City="Sivas", Phone = "+90542" },
            });

        }
    }
}
