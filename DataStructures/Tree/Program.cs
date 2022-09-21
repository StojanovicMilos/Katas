using Tree;

BinaryTree root = new BinaryTree
{
    Value = 1,
    Left = new BinaryTree
    {
        Value = 2,
        Left = new BinaryTree
        {
            Value = 4,
            Left = new BinaryTree { Value = 8 },
            Right = new BinaryTree { Value = 9 }
        },
        Right = new BinaryTree
        {
            Value = 5,
            Left = new BinaryTree { Value = 10 },
            Right = new BinaryTree { Value = 11 }
        }
    },
    Right = new BinaryTree
    {
        Value = 3,
        Left = new BinaryTree
        {
            Value = 6,
            Left = new BinaryTree { Value = 12 },
            Right = new BinaryTree { Value = 13 }
        },
        Right = new BinaryTree
        {
            Value = 7,
            Left = new BinaryTree { Value = 14 },
            Right = new BinaryTree { Value = 15 }
        }
    }
};

Console.WriteLine($"dfspreorder: {string.Join(", ", root.DFSPreorder())}");
Console.WriteLine($"dfspostorder: {string.Join(", ", root.DFSPostOrder())}");
Console.WriteLine($"dfsinorder: {string.Join(", ", root.DFSInorder())}");
Console.WriteLine($"bfs: {string.Join(", ", root.BFS())}");