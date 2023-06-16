using System.ComponentModel.DataAnnotations;

namespace App.Data.Entity;

public class PostComment
{
    public int Id { get; set; }

    public int? PostId { get; set; }

    public Post? Post { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public User? User { get; set; }

    [Required]
    public string? Comment { get; set; }

    [Required]
    public bool IsActive { get; set; }
}


