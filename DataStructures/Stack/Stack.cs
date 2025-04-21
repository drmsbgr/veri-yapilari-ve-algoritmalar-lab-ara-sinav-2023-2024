using DataStructures.LinkedList.Doubly;
using DataStructures.Stack.Contract;

namespace DataStructures.Stack;

public class Stack<T> : IStack<T>
{
    private readonly IStack<T> _stack;
    public Stack()
    {
        _stack = new LinkedListStack<T>();
    }

    public int Count => _stack.Count;

    public T Peek()
    {
        return _stack.Peek();
    }

    public T Pop()
    {
        return _stack.Pop();
    }

    public void Push(T item)
    {
        _stack.Push(item);
    }

    public DoublyLinkedList<T> ToDoublyLinkedList()
    {
        var linkedList = new DoublyLinkedList<T>();

        while (Count > 0)
        {
            var item = Pop();
            linkedList.AddLast(item);
        }

        return linkedList;
    }
}
