using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Kumojin.Evennements.Evennements
{
    public class EvennementAppService : CrudAppService<
        Evenemment, //The Evenemment entity
        EvennementDto, //Used to show Evenemmentes
        Guid, //Primary key of the Evenemment entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateEvennementDto>, //Used to create/update a Evenemment
        IEvennementAppService //implement the IEvenemmentAppService
    {
        public EvennementAppService(IRepository<Evenemment, Guid> repository)
           : base(repository)
        {

        }
    }
}
