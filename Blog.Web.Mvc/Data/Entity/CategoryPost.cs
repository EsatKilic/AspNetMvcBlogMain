using Microsoft.Build.Framework;
namespace Blog.Web.Mvc.Data.Entity
{
    public class CategoryPost
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int PostId { get; set; }

        public Category? Category { get; set; }
        public Post? Post { get; set; }
    }
}
