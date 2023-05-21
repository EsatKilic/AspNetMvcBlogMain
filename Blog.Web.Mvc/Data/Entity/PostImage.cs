using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Mvc.Data.Entity
{
    public class PostImage
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int PostId { get; set; }

        public Post Post { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string ImagePath { get; set; }
    }
}


