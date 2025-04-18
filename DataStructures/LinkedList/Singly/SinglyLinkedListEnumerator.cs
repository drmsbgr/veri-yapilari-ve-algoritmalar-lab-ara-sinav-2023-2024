using System.Collections;

namespace DataStructures.LinkedList.Singly;

public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
{
    private SinglyLinkedListNode<T>? head;
    private SinglyLinkedListNode<T>? curr;

    public T Current => curr.Value;

    object IEnumerator.Current => Current;

    public SinglyLinkedListEnumerator(SinglyLinkedListNode<T>? head)
    {
        this.head = head;
        curr = null;
    }

    public void Dispose()
    {
        head = null;
        GC.SuppressFinalize(this);
    }

    public bool MoveNext()
    {
        if (head is null)
            return false;

        if (curr is null)
        {
            curr = head;
            return true;
        }

        if (curr.Next is not null)
        {
            curr = curr.Next;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        curr = null;
    }
}