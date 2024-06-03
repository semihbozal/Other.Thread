using Other.Thread.Samples;
using Xunit;

namespace Other.Thread.EntityFrameworkCore.Applications;

[Collection(ThreadTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ThreadEntityFrameworkCoreTestModule>
{

}
