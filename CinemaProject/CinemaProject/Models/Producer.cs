using CinemaProject.Models;
using System.ComponentModel.DataAnnotations;

namespace CinemaProject.Models;

public class Producer
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Full name")]
    public string FullName { get; set; }
    [Display(Name = "Biography")]
    public string Bio { get; set; }
    [Display(Name = "Profile image")]
    public string ProfileImageUrl { get; set; }

    // relationships
    public List<Movie> Movies { get; set; }
}
