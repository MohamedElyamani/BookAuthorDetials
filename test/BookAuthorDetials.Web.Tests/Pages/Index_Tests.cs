using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace BookAuthorDetials.Pages;

[Collection(BookAuthorDetialsTestConsts.CollectionDefinitionName)]
public class Index_Tests : BookAuthorDetialsWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
