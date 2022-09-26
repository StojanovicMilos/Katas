public class Solution
{
    public bool EquationsPossible(string[] inputString)
    {
        var equations = inputString.Select(i => new Equation(i)).ToArray();
        var equalsEquations = equations.Where(e => e.Equal).ToList();
        var notEqualEquations = equations.Where(e => !e.Equal).ToList();
        var graphNodes = GenerateGraph(equalsEquations);

        var graphs = SearchGraph(graphNodes);
        return notEqualEquations.All(notEqualsEquation => InAlignment(graphs, notEqualsEquation));
    }

    private static List<GraphNode> GenerateGraph(List<Equation> equalsEquations)
    {
        var graphNodes = new List<GraphNode>();
        foreach (var equalsEquation in equalsEquations)
        {
            if(equalsEquation.Variable1 == equalsEquation.Variable2)
            {
                var node = graphNodes.SingleOrDefault(node => node.Letter == equalsEquation.Variable1);
                if(node == null)
                {
                    graphNodes.Add(new GraphNode(equalsEquation.Variable1));
                }

                continue;
            }

            var node1 = graphNodes.SingleOrDefault(node => node.Letter == equalsEquation.Variable1);
            var node2 = graphNodes.SingleOrDefault(node => node.Letter == equalsEquation.Variable2);
            if (node1 == null)
            {
                node1 = new GraphNode(equalsEquation.Variable1);
                graphNodes.Add(node1);
            }

            if (node2 == null)
            {
                node2 = new GraphNode(equalsEquation.Variable2);
                graphNodes.Add(node2);
            }

            node1.AddNeighbour(node2);
            node2.AddNeighbour(node1);
        }

        return graphNodes;
    }

    private List<List<char>> SearchGraph(List<GraphNode> graphNodes)
    {
        var result = new List<List<char>>();
        for (int i = 0; i < graphNodes.Count; i++)
        {
            var node = graphNodes[i];
            if (node.Visited == true)
            {
                continue;
            }

            node.Visited = true;
            var chars = new List<char> { node.Letter };
            chars = AddNeighboursTo(chars, node.Neighbours);
            result.Add(chars);
        }

        return result;
    }

    private List<char> AddNeighboursTo(List<char> chars, List<GraphNode> neighbours)
    {
        for (int i = 0; i < neighbours.Count; i++)
        {
            var neighbour = neighbours[i];
            if (neighbour.Visited)
            {
                continue;
            }

            chars.Add(neighbour.Letter);
            neighbour.Visited = true;
            chars = AddNeighboursTo(chars, neighbour.Neighbours);
        }

        return chars;
    }

    private static bool InAlignment(List<List<char>> graphs, Equation notEqualsEquation)
    {
        if(notEqualsEquation.Variable1 == notEqualsEquation.Variable2)
        {
            return false;
        }
        var graph1 = graphs.SingleOrDefault(graph => graph.Contains(notEqualsEquation.Variable1));
        var graph2 = graphs.SingleOrDefault(graph => graph.Contains(notEqualsEquation.Variable2));

        return graph1 != graph2 || (graph1 == null && graph2 == null);
    }


    private class Equation
    {
        public char Variable1 { get; private set; }
        public char Variable2 { get; private set; }
        public bool Equal { get; private set; }

        public Equation(string equation)
        {
            Variable1 = equation[0];
            Equal = equation[1] == '=';
            Variable2 = equation[3];
        }
    }

    private class GraphNode
    {
        public bool Visited { get; set; } = false;
        public char Letter { get; private set; }
        public List<GraphNode> Neighbours { get; private set; }

        public GraphNode(char letter)
        {
            Letter = letter;
            Neighbours = new List<GraphNode>();
        }

        public void AddNeighbour(GraphNode neighbour)
        {
            Neighbours.Add(neighbour);
        }
    }
}
