using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Kumojin.Evennements.Evennements
{
    public interface IEvennementAppService : ICrudAppService< //Defines CRUD methods
        EvennementDto,
        Guid, //Primary key of the Evenemment entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateEvennementDto>
    {
    }
}
