using System.Collections;

namespace DataStructures.LinkedList.Doubly;

public class DbLinkedListEnumerator<T> : IEnumerator<T>
{
    private DbNode<T>? Head { get; set; }
    private DbNode<T>? Tail { get; set; }
    public DbNode<T>? Curr { get; set; }

    public DbLinkedListEnumerator()
    {

    }

    public DbLinkedListEnumerator(DbNode<T>? head, DbNode<T>? tail)
    {
        Head = head;
        Tail = tail;
        Curr = null;
    }

    public T Current => Curr is not null ? Curr.Value : default;

    object? IEnumerator.Current => Current;

    public void Dispose()
    {
        Head = null;
        Tail = null;
        GC.SuppressFinalize(this);
    }

    public bool MoveNext()
    {
        if (Tail is null)
            return false;

        if (Curr is null)
        {
            Curr = Tail;
            return true;
        }

        if (Curr.Prev is not null)
        {
            Curr = Curr.Prev;
            return true;
        }

        return false;
    }

    public void Reset()
    {
        Head = null;
        Tail = null;
        Curr = null;
    }
}