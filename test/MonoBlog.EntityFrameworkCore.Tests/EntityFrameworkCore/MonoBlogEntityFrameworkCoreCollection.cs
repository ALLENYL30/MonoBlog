using Xunit;

namespace MonoBlog.EntityFrameworkCore;

[CollectionDefinition(MonoBlogTestConsts.CollectionDefinitionName)]
public class MonoBlogEntityFrameworkCoreCollection : ICollectionFixture<MonoBlogEntityFrameworkCoreFixture>
{
}