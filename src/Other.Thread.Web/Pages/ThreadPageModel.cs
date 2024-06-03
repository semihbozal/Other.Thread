using OtherThread.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Other.Thread.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ThreadPageModel : AbpPageModel
{
    protected ThreadPageModel()
    {
        LocalizationResourceType = typeof(OtherThreadResource);
    }
}
