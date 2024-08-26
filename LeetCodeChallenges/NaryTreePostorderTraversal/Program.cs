// https://leetcode.com/problems/n-ary-tree-postorder-traversal/description/
Console.WriteLine("Hello, World!");

var input = new Node(1,
[
    new Node(3, [new Node(5), new Node(6)]),
    new Node(2),
    new Node(4)
]);

Console.WriteLine(string.Join(",", Postorder(input)));

IList<int> Postorder(Node root)
{
    if (root == null)
    {
        return new List<int>();
    }

    var result = new List<int>();
    foreach (var child in root.children)
    {
        result.AddRange(Postorder(child));
    }

    result.Add(root.val);
    return result;
}