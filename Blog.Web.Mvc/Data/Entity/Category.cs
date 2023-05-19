using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace Blog.Web.Mvc.Data.Entity
{
    public class Category
    {
       

        [Required]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string? Name { get; set; }

		[Column(TypeName = "nvarchar(120)")]
		public string? Slug { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string? Description { get; set; }

        public List<Post> Posts { get; set; }
    }
}
