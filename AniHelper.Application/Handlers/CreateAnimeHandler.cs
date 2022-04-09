using AniHelper.Application.Commands;
using AniHelper.Application.Mappers;
using AniHelper.Application.Responses;
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
    public class CreateAnimeHandler: IRequestHandler<CreateAnimeCommand, AnimeResponse>
    {
        private readonly IAnimeRepository _animeRepository;
        public CreateAnimeHandler(IAnimeRepository animeRepository)
        {
            _animeRepository = animeRepository;
        }
        public async Task<AnimeResponse> Handle(CreateAnimeCommand request, CancellationToken cancellationToken)
        {
            var animeEntitiy = AnimeMapper.Mapper.Map<Anime>(request);
            if (animeEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newAnime = await _animeRepository.AddAsync(animeEntitiy);
            var animeResponse = AnimeMapper.Mapper.Map<AnimeResponse>(newAnime);
            return animeResponse;
        }
    }
}
