using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MonoBlog.Pages;

[Collection(MonoBlogTestConsts.CollectionDefinitionName)]
public class Index_Tests : MonoBlogWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}