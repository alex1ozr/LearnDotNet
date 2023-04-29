using Xunit;

namespace LearnDotNet.WebAppSample.ContainerTests;

[CollectionDefinition(Name)]
public class IntegrationTestCollection : ICollectionFixture<TestApplication>
{
    public const string Name = "Container tests collection";
}