using Bin_tree;

var t = new Tree();

t.AddNode(5);
t.AddNode(2);
t.AddNode(7);
t.AddNode(1);
t.AddNode(3);
t.AddNode(6);
t.AddNode(8);

//BFS
Console.WriteLine("\nBFS\n");
foreach (var node in t.BFS())
{
    Console.Write($"{node,3}");
}
Console.WriteLine();

// Straight
Console.WriteLine("\nStraight DFS\n");
List<int> res1 = new List<int>();
t.DFS_STR(res1, t.root);

foreach (var i in res1)
{
    Console.Write($"{i,3}");
}
Console.WriteLine();

//Symmetrical
Console.WriteLine("\nSymmetrical DFS\n");
List<int> res2 = new List<int>();
t.DFS_SYM(res2, t.root);

foreach (var i in res2)
{
    Console.Write($"{i,3}");
}
Console.WriteLine();

//Reverse
Console.WriteLine("\nReverse DFS\n");
List<int> res3 = new List<int>();
t.DFS_REV(res3, t.root);

foreach (var i in res3)
{
    Console.Write($"{i,3}");
}
Console.WriteLine();

//Removing
Console.WriteLine("\nRemoving node №2 with its child\n");
t.RemoveWithOneChild(2);
foreach (var node in t.BFS())
{
    Console.Write($"{node,3}");
}
Console.WriteLine();


































