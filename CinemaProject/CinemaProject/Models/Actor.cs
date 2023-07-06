using System.ComponentModel.DataAnnotations;

namespace CinemaProject.Models;

public class Actor
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Full name")]
    public string FullName { get; set; }
    [Display(Name = "Biography")]
    public string Bio { get; set; }
    [Display(Name = "Profile picture")]
    public string ProfileImageUrl { get; set; }

    // relationships 
    public List<Actor_Movie> Actor_Movies { get; set; }

}
