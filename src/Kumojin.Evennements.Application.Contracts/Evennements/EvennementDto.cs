using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Kumojin.Evennements.Evennements
{
    public class EvennementDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
