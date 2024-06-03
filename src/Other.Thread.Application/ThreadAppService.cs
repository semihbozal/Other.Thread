using System;
using System.Collections.Generic;
using System.Text;
using OtherThread.Localization;
using Volo.Abp.Application.Services;

namespace Other.Thread;

/* Inherit your application services from this class.
 */
public abstract class ThreadAppService : ApplicationService
{
    protected ThreadAppService()
    {
        LocalizationResource = typeof(OtherThreadResource);
    }
}
