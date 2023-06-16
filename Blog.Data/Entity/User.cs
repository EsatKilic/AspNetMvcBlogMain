using App.Data.Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entity;

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

    public List<PostComment>? PostComment { get; set; }
}

