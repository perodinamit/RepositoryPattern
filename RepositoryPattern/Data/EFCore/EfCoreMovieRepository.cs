using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, RepositoryPatternContext>
    {
        public EfCoreMovieRepository(RepositoryPatternContext contex) : base(contex)
        {

        }

        // We can add new methods specific to the movie repository here in the future
    }
}
