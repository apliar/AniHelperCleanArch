using AniHelper.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniHelper.Application.Queries
{
    public class GetAllAnimeQuery : IRequest<IReadOnlyList<Anime>>
    {
        public int AnimeId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Synopsis { get; set; }
        public GetAllAnimeQuery() { }
    }
}
