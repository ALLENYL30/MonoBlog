using Microsoft.AspNetCore.Builder;
using MonoBlog;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("MonoBlog.Web.csproj");
await builder.RunAbpModuleAsync<MonoBlogWebTestModule>(applicationName: "MonoBlog.Web");

public partial class Program
{
}