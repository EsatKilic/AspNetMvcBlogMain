using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Web.Mvc.Data.Entity
{
    public class Setting
    {
        [Required]
        public int Id { get; set; }

        public int? UserId { get; set; }

        public User? User { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(400)")]
        public string Value { get; set; }
    }
}