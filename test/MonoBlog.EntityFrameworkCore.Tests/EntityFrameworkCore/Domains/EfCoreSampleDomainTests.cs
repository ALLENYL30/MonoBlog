using MonoBlog.Samples;
using Xunit;

namespace MonoBlog.EntityFrameworkCore.Domains;

[Collection(MonoBlogTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MonoBlogEntityFrameworkCoreTestModule>
{
}