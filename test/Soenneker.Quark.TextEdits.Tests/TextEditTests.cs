using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.TextEdits.Tests;

[Collection("Collection")]
public sealed class TextEditTests : FixturedUnitTest
{
    public TextEditTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
