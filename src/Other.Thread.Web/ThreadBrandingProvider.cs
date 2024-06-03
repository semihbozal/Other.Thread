using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Other.Thread.Web;

[Dependency(ReplaceServices = true)]
public class ThreadBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Thread";
}
