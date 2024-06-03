using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Other.Thread.Pages;

public class Index_Tests : ThreadWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
