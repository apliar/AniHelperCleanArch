using AniHelper.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniHelper.Application.Commands
{
    public class CreateAnimeCommand : IRequest<AnimeResponse>
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Synopsis { get; set; }
    }
}
