using DataStructures.LinkedList.Singly;

namespace LinkedListTests;

public class SinglyLinkedListTests
{
    [Fact]
    public void AddFirst_with_SinglyLinkedListNode_Parameters()
    {
        //Arrange
        var linkedList = new SinglyLinkedList<int>([23, 13, 55, 60, 34]);

        //Act
        var node = new SinglyLinkedListNode<int>(32);
        linkedList.AddFirst(node);

        //Assert
        ArgumentNullException.ThrowIfNull(linkedList.Head);
        Assert.Equal(32, linkedList.Head.Value);
    }

    [Fact]
    public void ToStack_Test()
    {
        //Arrange
        var linkedList = new SinglyLinkedList<int>([23, 13, 55, 60, 34]);

        //Act
        var stack = linkedList.ToStack();

        //Assert
        Assert.Equal(34, stack.Peek());
    }
}
