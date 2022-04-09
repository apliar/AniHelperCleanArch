using AniHelper.Application.Queries;
using AniHelper.Core.Entities;
using AniHelper.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniHelper.Application.Handlers
{
    public class GetAllAnimeHandler : IRequestHandler<GetAllAnimeQuery, IReadOnlyList<Anime>>
    {
        private readonly IAnimeRepository _animeRepository;
        public GetAllAnimeHandler(IAnimeRepository animeRepository)
        {
            _animeRepository = animeRepository;
        }
        public Task<IReadOnlyList<Anime>> Handle(GetAllAnimeQuery request, CancellationToken cancellationToken)
        {
            return _animeRepository.GetAllAsync();
        }
    }
}
