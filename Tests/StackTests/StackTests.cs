using DataStructures.Stack;

namespace Tests.StackTests;

public class StackTests
{
    [Fact]
    public void ToDoublyLinkedList_Test()
    {
        //Arrange
        var stack = new LinkedListStack<int>([15, 26, 39, 10]);

        //Act
        var linkedList = stack.ToDoublyLinkedList();

        //Assert
        Assert.Equal(4, linkedList.Count());
    }
}