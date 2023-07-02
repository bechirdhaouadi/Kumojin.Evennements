using System;
using System.Collections.Generic;
using System.Text;
using Kumojin.Evennements.Localization;
using Volo.Abp.Application.Services;

namespace Kumojin.Evennements;

/* Inherit your application services from this class.
 */
public abstract class EvennementsAppService : ApplicationService
{
    protected EvennementsAppService()
    {
        LocalizationResource = typeof(EvennementsResource);
    }
}
