using Blog.Web.Mvc.Data.Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Mvc.Data.Entity
{
    public class PostComment : AuditEntity
    {
        public int Id { get; set; }

        public int? PostId { get; set; }

        public Post? Post { get; set; }

        public int? UserId { get; set; }

        public User? User { get; set; }

        [Required]
        public string? Comment { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}

