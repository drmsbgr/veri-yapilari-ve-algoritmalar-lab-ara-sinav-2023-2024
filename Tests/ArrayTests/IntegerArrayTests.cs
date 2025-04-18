using DataStructures;

namespace Tests.ArrayTests;

public class IntegerArrayTests
{
    [Fact]
    public void Mean_Test()
    {
        //Arrange
        var intArray = new IntegerArray(4);
        intArray.AddRange([10, 15, 25, 40]);

        //Act
        var mean = intArray.Mean();

        //Assert
        Assert.Equal(22.5, mean);
    }
}
