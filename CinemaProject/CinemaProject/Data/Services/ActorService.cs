using CinemaProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CinemaProject.Data.Services;

public class ActorService : IActorService
{
    private readonly ApplicationDbContext _context;

    public ActorService(ApplicationDbContext dbContext)
    {
        _context = dbContext;
    }

    public void Add(Actor actor)
    {
        _context.Actors.Add(actor);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var delActor = _context.Actors.Find(id);
        if (delActor != null)
        {
            if (!String.IsNullOrEmpty(delActor.ProfileImageUrl))
            {
                var delImage = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "wwwroot/images/actors",
                    delActor.ProfileImageUrl
                    );

                if (System.IO.File.Exists(delImage))
                {
                    System.IO.File.Delete(delImage);
                }
            }

            _context.Actors.Remove(delActor);
            
        }

        _context.SaveChanges();
    }

    public async Task<IEnumerable<Actor>> GetAllAsync()
    {
        var result = await _context.Actors.ToListAsync();
        return result;
    }

    public Actor GetById(int id)
    {
        var actor = _context.Actors.FirstOrDefault(a => a.Id == id);
        return actor;
    }

    public async Task<Actor> EditAsync(int id, Actor actor)
    {
        _context.Update(actor);
        await _context.SaveChangesAsync();
        return actor;
    }


    public bool ActorExists(int id)
    {
        return (_context.Actors?.Any(a => a.Id == id)).GetValueOrDefault();
    }

    public void RemoveRangeOfActorMovies(int id)
    {
        if(_context.Actors_Movies.Find(id) != null)
        {
            _context.Actors_Movies.RemoveRange(_context.Actors_Movies.Where(am => am.ActorId == id));
            _context.SaveChanges();
        }

    }

    public void AddConnectionTable(Actor_Movie actor_Movie)
    {
        _context.Actors_Movies.Add(actor_Movie);
        _context.SaveChanges();
    }
}
    
