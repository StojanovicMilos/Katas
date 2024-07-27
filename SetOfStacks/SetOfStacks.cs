
class SetOfStacks<T> : ISetOfStacks<T>
{
    private readonly uint _capacity;
    private readonly List<LimitedCapacityStack<T>> _stacks = [];

    public SetOfStacks(uint capacity)
    {
        ArgumentOutOfRangeException.ThrowIfZero(capacity);
        _capacity = capacity;
    }

    public void Push(T value)
    {
        if(_stacks.Count == 0)
        {
            _stacks.Add(new LimitedCapacityStack<T>(_capacity));
        }

        var successfulPush = TryPushToLastStack(value);
        if(successfulPush)
        {
            return;
        }

        _stacks.Add(new LimitedCapacityStack<T>(_capacity));
        TryPushToLastStack(value);
    }

    private bool TryPushToLastStack(T value)
    {
        var lastStack = _stacks.Last();
        return lastStack.TryPush(value);
    }

    public T Pop()
    {
        if (_stacks.Count == 0)
        {
            throw new InvalidOperationException("No data in stack");
        }

        var lastStack = _stacks.Last();
        var succesfulPop = lastStack.TryPop(out var result);
        if(succesfulPop)
        {
            if(lastStack.Count == 0)
            {
                _stacks.Remove(lastStack);
            }

            return result!;
        }

        _stacks.Remove(lastStack);
        lastStack.TryPop(out result);
        if (lastStack.Count == 0)
        {
            _stacks.Remove(lastStack);
        }
        return result!;
    }

    public T PopAt(uint index)
    {
        if(index > _stacks.Count - 1)
        {
            throw new InvalidOperationException($"Index {index} is out of range");
        }

        var stack = _stacks[_stacks.Count - 1 - (int)index];
        stack.TryPop(out var result);
        if(stack.Count == 0)
        {
            _stacks.Remove(stack);
        }

        return result!;
    }

    public override string ToString() => $"[{string.Join("; ", _stacks.Select(stack => stack.ToString()))}]";
}
