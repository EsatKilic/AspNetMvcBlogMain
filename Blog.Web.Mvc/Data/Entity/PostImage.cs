using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NuGet.Protocol;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Blog.Web.Mvc.Data.Entity
{
    public class PostImage
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string ImagePath { get; set; }
    }
}


