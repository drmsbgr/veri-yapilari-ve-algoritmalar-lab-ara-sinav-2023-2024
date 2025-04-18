using DataStructures.Contracts;

namespace DataStructures;

public class Array<T> : StaticArray<T>, IDynamicArray<T>
{
    private int index = 0;

    public int Count => index;

    public int Capacity => Length;

    public T this[int index] => GetValue(index);

    public Array()
    {

    }

    public Array(int size)
    {
        _innerArray = new T[size];
    }

    public Array(IEnumerable<T> items)
        : this()
    {
        AddRange(items);
    }

    public void Add(T value)
    {
        CheckDoubleArray();
        _innerArray[index] = value;
        index++;
    }

    public void AddRange(IEnumerable<T> items)
    {
        foreach (var item in items)
            Add(item);
    }

    public T? Remove()
    {
        var removedItem = _innerArray[index - 1];
        _innerArray[index - 1] = default;
        index--;
        ShrinkArray();
        return removedItem;
    }

    public T RemoveAt(int position)
    {
        if (position < 0 || position > Count - 1)
        {
            throw new IndexOutOfRangeException();
        }


        var removedItem = _innerArray[position];

        _innerArray[position] = default;

        for (int i = position; i < Count - 1; i++)
        {
            Swap(i, i + 1);
        }
        index--;
        ShrinkArray();
        return removedItem;
    }

    public void Swap(int position1, int position2)
    {
        var temp = _innerArray[position1];
        _innerArray[position1] = _innerArray[position2];
        _innerArray[position2] = temp;
    }

    public void Concat(ICollection<T> arr)
    {
        AddRange(arr);
        /*
        var newArray = new T[Capacity + arr.ToList().Capacity];
        for (int i = 0; i < Count; i++)
            newArray[i] = _innerArray[i];
        int j = Count;
        for (int i = 0; i < arr.Count; i++)
        {
            newArray[j] = arr.ElementAt(i);
            j++;
        }
        _innerArray = newArray;*/
    }

    public T[] Sort()
    {
        System.Array.Sort<T>(_innerArray, 0, index);
        return _innerArray;
    }

    public T GetValue(int position)
    {
        // throw new NotImplementedException();
        if (position < 0 || position >= _innerArray.Length)
            throw new IndexOutOfRangeException();
        return _innerArray[position];
    }

    public void SetValue(T value, int position)
    {
        if (position < 0 || position >= _innerArray.Length)
            throw new IndexOutOfRangeException();
        _innerArray[position] = value;
    }

    private void CheckDoubleArray()
    {
        //if (Count.Equals(Capacity))
        if (index.Equals(_innerArray.Length))
        {
            var newArray = new T[_innerArray.Length * 2];
            for (int i = 0; i < _innerArray.Length; i++)
            {
                newArray[i] = _innerArray[i];
            }
            _innerArray = newArray;
        }
    }

    private void ShrinkArray()
    {
        if (Count <= Capacity / 4)
        {
            var newArray = new T[Capacity / 2];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = _innerArray[i];
            }
            _innerArray = newArray;
        }
    }
}