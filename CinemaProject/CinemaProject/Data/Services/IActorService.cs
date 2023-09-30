using CinemaProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaProject.Data.Services;

public interface IActorService
{
    Task<IEnumerable<Actor>> GetAllAsync();
    Actor GetById(int id);
    void Add(Actor actor);
    Task<Actor> EditAsync(int id, Actor newActor);
    void Delete(int id);
    bool ActorExists(int id);
    void RemoveRangeOfActorMovies(int id);
    void AddConnectionTable(Actor_Movie actor_Movie);
}
