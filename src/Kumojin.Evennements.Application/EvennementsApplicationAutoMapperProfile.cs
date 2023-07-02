using AutoMapper;
using Kumojin.Evennements.Evennements;

namespace Kumojin.Evennements;

public class EvennementsApplicationAutoMapperProfile : Profile
{
    public EvennementsApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Kumojin.Evennements.Evennements.Evenemment, EvennementDto>();
        CreateMap<CreateUpdateEvennementDto, EvennementDto>();
    }
}
