
interface ISetOfStacks<T>
{
    void Push(T value);
    T Pop();
    T PopAt(uint index);
}
