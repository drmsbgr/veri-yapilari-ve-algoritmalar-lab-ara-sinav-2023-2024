using DataStructures.Stack;

namespace Tests.StackTests;

public class StackTests
{
    [Fact]
    public void ToDoublyLinkedList_Test()
    {
        //Arrange
        var v = new int[] { 15, 26, 39, 10 };
        var linkedListStack = new LinkedListStack<int>(v);
        var arrayStack = new ArrayStack<int>(v);

        //Act
        var db1 = linkedListStack.ToDoublyLinkedList();
        var db2 = arrayStack.ToDoublyLinkedList();

        //Assert
        Assert.Equal(4, db1.Count());
        Assert.Equal(4, db2.Count());
    }
}