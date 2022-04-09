using AniHelper.Core.Entities;
using AniHelper.Core.Repositories;
using AniHelper.Infrastructure.Data;
using AniHelper.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniHelper.Infrastructure.Repositories
{
    public class AnimeRepository: Repository<Anime>, IAnimeRepository
    {
        public AnimeRepository(AnimeContext animeContext) : base(animeContext) { }
        public async Task<IEnumerable<Anime>> GetAnimeByName(string name)
        {
            return await _animeContext.Animes.Where(m => m.Name == name).ToListAsync();
        }
    }
}
