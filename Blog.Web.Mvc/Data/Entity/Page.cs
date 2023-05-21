using Blog.Web.Mvc.Data.Entity.Abstract;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Mvc.Data.Entity
{
    public class Page : AuditEntity

    {
        [Required]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(120)")]
        public string? Slug { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Title { get; set; }

        [Required]
        public string Context { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}