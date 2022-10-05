// See https://aka.ms/new-console-template for more information
Console.WriteLine(string.Join(", ", GenerateParentheses(15)));

List<string> GenerateParentheses(int n)
{
    List<string> result = new List<string>();
    Queue<State> queue = new Queue<State>();
    queue.Enqueue(new State { Diff = 0, Parentheses = string.Empty });
    while (queue.Count > 0)
    {
        var current = queue.Dequeue();
        if (current.Parentheses.Length == 2 * n)
        {
            if (current.Diff == 0)
            {
                result.Add(current.Parentheses);
            }
            continue;
        }

        if(current.Diff > n)
        {
            continue;
        }

        if (current.Diff > 0)
        {
            var newOpened = new State { Diff = current.Diff + 1, Parentheses = current.Parentheses + "(" };
            queue.Enqueue(newOpened);

            //use current for new closed
            current.Diff--;
            current.Parentheses += ")";
            queue.Enqueue(current);
        }
        else
        {
            //use current for new opened
            current.Diff++;
            current.Parentheses += "(";
            queue.Enqueue(current);
        }
    }

    return result;
}

class State
{
    public int Diff { get; set; }
    public string Parentheses { get; set; }
}