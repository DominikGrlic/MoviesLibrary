using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaProject.Models;

public class Actor
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Full name")]
    [Required(ErrorMessage ="Full name is required!")]
    [StringLength(50, MinimumLength = 3)]
    public string FullName { get; set; }
    [Display(Name = "Biography")]
    [Required(ErrorMessage ="Biography is required!")]
    public string Bio { get; set; }
    [Display(Name = "Profile picture")]
    [Column(TypeName ="nvarchar(200)")]
    public string? ProfileImageUrl { get; set; }

    // relationships 
    public List<Actor_Movie>? Actor_Movies { get; set; }

}
