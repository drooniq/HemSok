using AutoMapper;
using HemSok.Models;

namespace HemSok.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Agent, AgentDTO>();
            CreateMap<AgentDTO, Agent>();
            CreateMap<Residence, ResidenceDTO>();
            CreateMap<ResidenceDTO, Residence>();
        }
    }
}
