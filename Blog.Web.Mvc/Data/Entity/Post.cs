using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Blog.Web.Mvc.Data.Entity.Abstract;

namespace Blog.Web.Mvc.Data.Entity
{
    public class Post : AuditEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }

        public User User { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string? Title { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string? Content { get; set; }

		public Category? Category { get; set; }
    }
}
