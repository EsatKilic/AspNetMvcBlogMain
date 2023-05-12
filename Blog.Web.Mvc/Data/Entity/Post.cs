using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Blog.Web.Mvc.Data.Entity
{
    public class Post
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string? Title { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string? Content { get; set; }
    }
}
