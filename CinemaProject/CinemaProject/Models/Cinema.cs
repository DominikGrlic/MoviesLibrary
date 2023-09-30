using CinemaProject.Models;
using System.ComponentModel.DataAnnotations;

namespace CinemaProject.Models;

public class Cinema
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string? Logo { get; set; }

    // relationships 
    public List<Movie> Movies { get; set; }
}
