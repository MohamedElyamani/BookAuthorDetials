using Microsoft.AspNetCore.Builder;
using BookAuthorDetials;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<BookAuthorDetialsWebTestModule>();

public partial class Program
{
}
