using Microsoft.AspNetCore.Builder;
using Other.Thread;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ThreadWebTestModule>();

public partial class Program
{
}
