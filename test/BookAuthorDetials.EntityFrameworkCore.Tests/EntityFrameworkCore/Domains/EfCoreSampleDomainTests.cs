using BookAuthorDetials.Samples;
using Xunit;

namespace BookAuthorDetials.EntityFrameworkCore.Domains;

[Collection(BookAuthorDetialsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookAuthorDetialsEntityFrameworkCoreTestModule>
{

}
