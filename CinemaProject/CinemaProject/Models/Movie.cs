using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CinemaProject.Models;
using CinemaProject.Data;

namespace CinemaProject.Models;

public class Movie
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double Price { get; set; }
    public string ImageUrl { get; set; }
    public MovieCategory MovieCategory { get; set; }

    // relationships
    public List<Actor_Movie> Actor_Movies { get; set; }

    // cinema
    public int CinemaId { get; set; }
    [ForeignKey(nameof(CinemaId))]
    public Cinema Cinema { get; set; }

    // producer
    public int ProducerId { get; set; }
    [ForeignKey(nameof(ProducerId))]
    public Producer Producer { get; set; }
}
