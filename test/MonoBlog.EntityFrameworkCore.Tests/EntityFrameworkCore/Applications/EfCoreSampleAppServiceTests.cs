using MonoBlog.Samples;
using Xunit;

namespace MonoBlog.EntityFrameworkCore.Applications;

[Collection(MonoBlogTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MonoBlogEntityFrameworkCoreTestModule>
{
}