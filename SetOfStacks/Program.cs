//Imagine a (literal) stack of plates. If the stack gets too high, it might topple. Therefore, in real life, we would likely start a new stack when the previous stack exceeds some threshold. Implement a data structure SetOfStacks that mimics this. SetOfStacks should be composed of several stacks and should create a new stack once the previous one exceeds capacity. SetOfStacks.Push() and SetOfStacks.Pop() should behave identically to a single stack (that is, Pop() should return the same values as it would if there were just a single stack.
//followup implement a function PopAt(uint index) which performs a pop operation on a specific sub-stack
uint[] capacities = [1, 2, 5];

foreach (var capacity in capacities)
{
    var setOfStacks = new LoggingSetOfStacks<int>(new SetOfStacks<int>(capacity));

    setOfStacks.Push(1);
    setOfStacks.Push(2);
    setOfStacks.Push(3);
    setOfStacks.Push(4);
    setOfStacks.Push(5);
    setOfStacks.Push(6);
    setOfStacks.Push(7);
    setOfStacks.Push(8);
    setOfStacks.Push(9);
    setOfStacks.Push(10);
    setOfStacks.PopAt(1);
    setOfStacks.PopAt(0);
    setOfStacks.Pop();
    setOfStacks.PopAt(1);
    setOfStacks.Pop();
    setOfStacks.Pop();
    setOfStacks.Pop();
    setOfStacks.Pop();
    setOfStacks.Pop();
    setOfStacks.Pop();
}