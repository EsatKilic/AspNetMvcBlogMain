using Blog.Web.Mvc.Data.Entity.Abstract;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Mvc.Data.Entity
{
    public class User : AuditEntity
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? City { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? Phone { get; set; }

      
    }
}
