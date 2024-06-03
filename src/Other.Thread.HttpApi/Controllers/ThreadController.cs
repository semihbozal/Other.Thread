using OtherThread.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Other.Thread.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ThreadController : AbpControllerBase
{
    protected ThreadController()
    {
        LocalizationResource = typeof(OtherThreadResource);
    }
}
