
class LoggingSetOfStacks<T> : ISetOfStacks<T>
{
    private readonly ISetOfStacks<T> _stacks;

    public LoggingSetOfStacks(ISetOfStacks<T> stacks)
    {
        _stacks = stacks ?? throw new ArgumentNullException(nameof(stacks));
        Console.WriteLine($"initial:\t{_stacks}");
    }

    public void Push(T value)
    {
        _stacks.Push(value);
        Console.WriteLine($"push {value}:\t\t{_stacks}");
    }

    public T Pop()
    {
        var result = _stacks.Pop();
        Console.WriteLine($"Pop:\t\t{_stacks} -> {result}");
        return result;
    }

    public T PopAt(uint index)
    {
        var result = _stacks.PopAt(index);
        Console.WriteLine($"PopAt {index}:\t{_stacks} -> {result}");
        return result;
    }
}
