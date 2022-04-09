using AniHelper.Core.Entities;
using AniHelper.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniHelper.Core.Repositories
{
    public interface IAnimeRepository: IRepository<Anime>
    {
        Task<IEnumerable<Anime>> GetAnimeByName(string name);
    }
}
