

class LimitedCapacityStack<T>
{
    private readonly Stack<T> _stack;
    private readonly uint _capacity;

    public LimitedCapacityStack(uint capacity)
    {
        ArgumentOutOfRangeException.ThrowIfZero(capacity);
        _stack = new Stack<T>((int)capacity);
        _capacity = capacity;
    }

    public bool TryPop(out T? result) => _stack.TryPop(out result);

    public bool TryPush(T value)
    {
        if (_stack.Count >= _capacity)
        {
            return false;
        }

        _stack.Push(value);
        return true;
    }

    public int Count => _stack.Count;

    public override string ToString() => $"[{string.Join(",", _stack.Reverse().ToArray().Select(element => element!.ToString()))}]";
}