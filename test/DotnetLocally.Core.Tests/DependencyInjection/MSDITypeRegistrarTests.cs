using DotnetLocally.Core.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Spectre.Console.Testing;

namespace DotnetLocally.Core.Tests.DependencyInjection;

public class MSDITypeRegistrarTests {
    [Fact]
    public void SpectreTests_WhenCalled_ShouldNotThrow() {
        var baseTests = new TypeRegistrarBaseTests(() => new MSDITypeRegistrar(new ServiceCollection()));
        Should.NotThrow(() => baseTests.RunAllTests());
    }
}
