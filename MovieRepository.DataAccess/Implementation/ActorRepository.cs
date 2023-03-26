using Microsoft.EntityFrameworkCore;
using MovieRepository.DataAccess.Context;
using MovieRepository.Domain.Entities;
using MovieRepository.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRepository.DataAccess.Implementation
{
    public class ActorRepository : GenericRepository<Actor>,IActorRepository
    {

        public ActorRepository(MovieManagementDbContext context) : base(context)
        {

        }

        public IEnumerable<Actor> GetActorsWihMovies()
        {
            var actorsWithMovies = _context.Actors.Include(u => u.Movies).ToList();
            return actorsWithMovies;
        }
    }
}
