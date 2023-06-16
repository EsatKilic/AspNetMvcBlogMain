using App.Data.Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entity;

public class Post : AuditEntity
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }

    public User User { get; set; }

    [Column(TypeName = "nvarchar(120)")]
    public string? Slug { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string? Title { get; set; }

    [Required]
    [Column(TypeName = "ntext")]
    public string? Content { get; set; }

    public bool IsFeatured { get; set; }

    public List<Category> Categories { get; set; } = new();

    public List<PostImage>? PostImages { get; set; } = new();

    public List<PostComment>? PostComments { get; set; } = new();
}

