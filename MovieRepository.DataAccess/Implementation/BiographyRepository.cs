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
    public class BiographyRepository : GenericRepository<Biography>, IBiographyRepository
    {
        public BiographyRepository(MovieManagementDbContext context) : base(context)
        {
        }
    }
}
