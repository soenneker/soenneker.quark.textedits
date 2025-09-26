using Soenneker.Tests.FixturedUnit;
using Soenneker.Quark.Validations.Abstract;
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

    [Fact]
    public void ImplementsIValidationInput()
    {
        // Arrange
        var textEdit = new TextEdit();

        // Act & Assert
        Assert.IsAssignableFrom<IValidationInput>(textEdit);
    }

    [Fact]
    public void ValidationValue_ReturnsValue()
    {
        // Arrange
        var textEdit = new TextEdit
        {
            Value = "test value"
        };

        // Act
        var validationValue = ((IValidationInput)textEdit).ValidationValue;

        // Assert
        Assert.Equal("test value", validationValue);
    }
}
