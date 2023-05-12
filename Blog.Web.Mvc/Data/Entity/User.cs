using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NuGet.Protocol;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace Blog.Web.Mvc.Data.Entity
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public int  Phone { get; set; }
        
    }
}
