using CinemaProject.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaProject.Models;

public class Actor_Movie
{
    public int MovieId { get; set; }
    [ForeignKey(nameof(MovieId))]
    public Movie Movie { get; set; }
    public int ActorId { get; set; }
    [ForeignKey(nameof(ActorId))]
    public Actor Actor { get; set; }
}
