using CinemaProject.Models;
using Microsoft.EntityFrameworkCore;

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
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Actor>> GetAll()
    {
        var result = await _context.Actors.ToListAsync();
        return result;
    }

    public Actor GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Actor Update(int id, Actor newActor)
    {
        throw new NotImplementedException();
    }
}
