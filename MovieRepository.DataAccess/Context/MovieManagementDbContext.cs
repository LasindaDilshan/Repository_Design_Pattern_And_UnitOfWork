using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MovieRepository.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRepository.DataAccess.Context
{
    public class MovieManagementDbContext :DbContext
    {
        public MovieManagementDbContext(DbContextOptions<MovieManagementDbContext> options) : base(options)
        { 

        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Biography> Biographies { get; set; }
        public DbSet<Genre> Genre { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1 , FirstName = "xyz" , LastName ="jkl"},
                new Actor { Id = 2, FirstName = "abc", LastName = "cde" },
                new Actor { Id = 3, FirstName = "efg", LastName = "ghi" }
                );
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id=1 , Name="Spiderman" , Description="Sri Lanka",ActorId=1},
                new Movie { Id = 2, Name = "Wakanda", Description = "Srilanka", ActorId = 2 },
                new Movie { Id = 3, Name = "Ironman", Description = "Srilanka", ActorId = 1 },
                new Movie { Id = 4, Name = "Harry Poter", Description = "Srilanka", ActorId = 3 }
                );
        }




    }
}
