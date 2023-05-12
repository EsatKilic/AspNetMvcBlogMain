using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Blog.Web.Mvc.Data.Entity
{
    public class Page
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Title { get; set; }
        [Required]
        public string Context { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
