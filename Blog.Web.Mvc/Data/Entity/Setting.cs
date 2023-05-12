using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NuGet.Protocol;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace Blog.Web.Mvc.Data.Entity
{
    public class Setting
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(400)")]
        public int? Value { get; set; }

    }
}
