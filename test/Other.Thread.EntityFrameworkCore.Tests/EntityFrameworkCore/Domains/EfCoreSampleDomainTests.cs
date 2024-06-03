using Other.Thread.Samples;
using Xunit;

namespace Other.Thread.EntityFrameworkCore.Domains;

[Collection(ThreadTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ThreadEntityFrameworkCoreTestModule>
{

}
