using Kumojin.Evennements.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Kumojin.Evennements.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EvennementsController : AbpControllerBase
{
    protected EvennementsController()
    {
        LocalizationResource = typeof(EvennementsResource);
    }
}
