using AutoMapper;
using Orion.API.CompetitionScorecard.DTO;
using Orion.Domain.IRepositories;

namespace Orion.API.CompetitionScorecard.Mappings;

public class CompetitionMatchProfile : Profile
{

        public CompetitionMatchProfile()
        {
            CreateMap<CompetitionMatch, CompetitionMatchDto>().ReverseMap();
        }
}