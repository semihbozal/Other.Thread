using Xunit;

namespace Other.Thread.EntityFrameworkCore;

[CollectionDefinition(ThreadTestConsts.CollectionDefinitionName)]
public class ThreadEntityFrameworkCoreCollection : ICollectionFixture<ThreadEntityFrameworkCoreFixture>
{

}
