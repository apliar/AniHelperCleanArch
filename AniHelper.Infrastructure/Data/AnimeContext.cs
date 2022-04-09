using AniHelper.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniHelper.Infrastructure.Data
{
    public class AnimeContext: DbContext
    {
        public AnimeContext(DbContextOptions<AnimeContext> options) : base(options) { }
        public DbSet<Anime> Animes { get; set; }
    }
}
