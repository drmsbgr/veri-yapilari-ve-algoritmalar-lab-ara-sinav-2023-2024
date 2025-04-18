namespace DataStructures;

public class IntegerArray(int capacity) : Array<int>(capacity)
{
    public double Mean()
    {
        return _innerArray.Average(x => x);
    }
}