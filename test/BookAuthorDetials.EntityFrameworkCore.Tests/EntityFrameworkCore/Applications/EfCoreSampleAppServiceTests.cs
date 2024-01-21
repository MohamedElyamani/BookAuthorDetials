using BookAuthorDetials.Samples;
using Xunit;

namespace BookAuthorDetials.EntityFrameworkCore.Applications;

[Collection(BookAuthorDetialsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookAuthorDetialsEntityFrameworkCoreTestModule>
{

}
