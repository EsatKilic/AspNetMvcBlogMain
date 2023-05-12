using Blog.Web.Mvc.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Mvc.Data
{
    public class DbSeed
    {
        public static void SeedDatas(ModelBuilder modelBuilder)
        {
            SeedCategories(modelBuilder);
            SeedCategoryPosts(modelBuilder);
            SeedPosts(modelBuilder);
            SeedPages(modelBuilder);
            SeedPostImages(modelBuilder);
            SeedUsers(modelBuilder);
            SeedSettings(modelBuilder);

        }

        public static void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new List<Category>
            {
                new() {Id = 1 , Name = "Innovation" , Description="find new things and discover the world"},
                new() {Id = 2 , Name = "Software" , Description="guide technological developments"},
                new() {Id = 3 , Name = "Social" , Description="use social media and effect our lifes"},
                new() {Id = 4 , Name = "Trends" , Description="popular things"},
            });
                
        }

        public static void SeedCategoryPosts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryPost>().HasData(new List<CategoryPost>
            {
                new() {Id = 1 , CategoryId = 1 , PostId= 1},
                new() {Id = 2 , CategoryId = 2 , PostId= 2},
                new() {Id = 3 , CategoryId = 3 , PostId =3 },
                new() {Id = 4 , CategoryId = 4 , PostId =4 },
            });

        }

        public static void SeedPosts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(new List<Post>
            {
                new() {Id = 1 , UserId = 1 , Title= "Innovation" , Content="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " },
                new() {Id = 2 , UserId = 2 , Title= "Software" , Content="Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo." },
                new() {Id = 3 , UserId = 3 , Title ="Social" , Content="But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. " },
                new() {Id = 4 , UserId = 4 , Title ="Trends" , Content="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga." },
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
                new() {Id = 1 , Title = "Innovation" , Context= "Lorem Ipsum is simply dummy text of the printing and typesetting industry." , IsActive=true },
                new() {Id = 2 , Title = "Software" , Context= "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. " , IsActive=true },
                new() {Id = 3 , Title ="Social" , Context ="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.", IsActive=true },
                new() {Id = 4 , Title = "Trends" , Context ="Contrary to popular belief, Lorem Ipsum is not simply random text." , IsActive=true },
            });

        }

        public static void SeedSettings(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setting>().HasData(new List<Setting>
            {
               new() {Id = 1 , UserId = 1 , Name= "Murat Esat KILIÇ"  },
                new() {Id = 2 , UserId = 2 , Name= "Ali Burhan GÜNCAN" },
                new() {Id = 3 , UserId = 3 , Name ="Ümit ARAS"  },
                new() {Id = 4 , UserId = 4 , Name ="Cem Hoca"  },
            });

        }

        public static void SeedUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new List<User>
            {
               new() {Id = 1 , Email = "esat@gmail.com" ,Password ="123", Name= "esat" , City="Ankara" ,Phone =+90532},
                new() {Id = 2 , Email = "ali@gmail.com" ,Password ="456", Name= "ali" , City="Mersin" ,Phone =+90536},
                new() {Id = 3 , Email ="umit@gmail.com" ,Password ="789", Name ="ümit" , City="İstanbul" ,Phone =+90505},
                new() {Id = 4 , Email ="cem@gmail.com" ,Password ="012", Name ="cem" , City="Ankara" ,Phone =+90542},
            });

        }
    }


}
