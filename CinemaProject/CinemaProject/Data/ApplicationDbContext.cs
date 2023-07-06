using CinemaProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CinemaProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // relationships between db models/tables
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(am => am.MovieId);

            modelBuilder.Entity<Actor_Movie>().HasOne(am => am.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(am => am.ActorId);

            // data seeding
            List<Actor> actors = new List<Actor>()
            {
                new Actor()
                {
                    Id = 1,
                    FullName = "Denzel Washington",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImageUrl = "_denzel.jpg"
                },
                new Actor()
                {
                    Id=2,
                    FullName = "Cilian Murphy",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImageUrl = "_cilian1.jpeg"
                },
                new Actor()
                {
                    Id=3,
                    FullName = "Tom Hardy",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImageUrl = "_hardy.jpg"
                },
                new Actor()
                {
                    Id=4,
                    FullName = "Al Pacino",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImageUrl = "_pacino.jpg"
                },
                new Actor()
                {
                    Id=5,
                    FullName = "Jason Statham",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImageUrl = "_statham.jpg"
                }
            };

            modelBuilder.Entity<Actor>().HasData(actors);

            List<Movie> movies = new List<Movie>()
            {
                new Movie()
                {
                    Id = 1,
                    Name = "Deadpool",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(10),
                    CinemaId = 1,
                    ProducerId = 1,
                    MovieCategory = MovieCategory.Comedy,
                    ImageUrl = "deadpool.jpg",
                    Price = 32.90
                },
                new Movie()
                {
                    Id = 2,
                    Name = "Fight Club",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(15),
                    CinemaId = 2,
                    ProducerId = 2,
                    MovieCategory = MovieCategory.Action,
                    ImageUrl = "fightClub.jpg",
                    Price = 39.50
                },
                new Movie()
                {
                    Id = 3,
                    Name = "God Father",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    StartDate = DateTime.Now.AddDays(-4),
                    EndDate = DateTime.Now.AddDays(10),
                    CinemaId = 3,
                    ProducerId = 3,
                    MovieCategory = MovieCategory.Crime,
                    ImageUrl = "godFather.jpg",
                    Price = 40.00
                },
                new Movie()
                {
                    Id = 4,
                    Name = "Mr and Mr's Smith",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    StartDate = DateTime.Now.AddDays(-2),
                    EndDate = DateTime.Now.AddDays(8),
                    CinemaId = 4,
                    ProducerId = 4,
                    MovieCategory = MovieCategory.Action,
                    ImageUrl = "mrMrs.jpg",
                    Price = 35.70
                },
                new Movie()
                {
                    Id = 5,
                    Name = "Training Day",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    StartDate = DateTime.Now.AddDays(3),
                    EndDate = DateTime.Now.AddDays(15),
                    CinemaId = 1,
                    ProducerId = 1,
                    MovieCategory = MovieCategory.Thriller,
                    ImageUrl = "trainingDay.jpg",
                    Price = 38.50
                }
            };

            modelBuilder.Entity<Movie>().HasData(movies);

            List<Cinema> cinemas = new List<Cinema>()
            {
                new Cinema()
                {
                    Id = 1,
                    Name = "Cinema 1",
                    Logo = "Cinema 1.jpg",
                    Description = "First cinema on the list"
                },
                new Cinema()
                {
                    Id = 2,
                    Name = "Cinema 2",
                    Logo = "Cinema 2.jpg",
                    Description = "Second cinema on the list"
                },
                new Cinema()
                {
                    Id=3,
                    Name = "Cinema 3",
                    Logo = "Cinema 3.jpg",
                    Description = "Third cinema on the list"
                },
                new Cinema()
                {
                    Id=4,
                    Name = "Cinema 4",
                    Logo = "Cinema 4.jpg",
                    Description = "Fourth cinema on the list"
                },
                new Cinema()
                {
                    Id=5,
                    Name = "Cinema 5",
                    Logo = "Cinema 5.jpg",
                    Description = "Fifth cinema on the list"
                }
            };

            modelBuilder.Entity<Cinema>().HasData(cinemas);

            List<Producer> producers = new List<Producer>()
            {
                new Producer()
                {
                    Id = 1,
                    FullName = "Martin Scorsese",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImageUrl = "martin_scorsese.jpg"
                },
                new Producer()
                {
                    Id = 2,
                    FullName = "Spike Lee",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImageUrl = "spike_lee.jpeg"
                },
                new Producer()
                {
                    Id = 3,
                    FullName = "Quentin Tarantino",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImageUrl = "quentin_tarantino.jpg"
                },
                new Producer()
                {
                    Id = 4,
                    FullName = "Steven Spilberg",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImageUrl = "steven_spilberg.jpg"
                },
                new Producer()
                {
                    Id = 5,
                    FullName = "James Cameron",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ProfileImageUrl = "james_cameron.jpg"
                }
            };

            modelBuilder.Entity<Producer>().HasData(producers);

            List<Actor_Movie> actor_Movies = new List<Actor_Movie>()
            {
                new Actor_Movie()
                {
                    ActorId = 1,
                    MovieId = 2,
                },
                new Actor_Movie()
                {
                    ActorId = 2,
                    MovieId = 3,
                },
                new Actor_Movie()
                {
                    ActorId = 3,
                    MovieId = 4,
                },
                new Actor_Movie()
                {
                    ActorId = 4,
                    MovieId = 5,
                },
                new Actor_Movie()
                {
                    ActorId = 5,
                    MovieId = 1,
                }
            };

            modelBuilder.Entity<Actor_Movie>().HasData(actor_Movies);
        }
    }
}
