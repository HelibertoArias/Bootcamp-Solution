using Xunit;

namespace AttributesConsoleApp.Tests
{
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //var x = new SomeInternalClass();
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void Test2(int input)
    {
        //Arrange
        //Assert
        //Act
    }
}
}