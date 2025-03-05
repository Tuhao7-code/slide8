using System;
using System.Text;

class Node
{
    public int Data { get; set; }
    public int Count { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int data)
    {
        this.Data = data;
        this.Count = 1;
        this.Left = this.Right = null;
    }
}

class BinarySearchTree
{
    private Node root;

    public void Insert(int data)
    {
        root = InsertRec(root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);
        else
            root.Count++;

        return root;
    }

    public void TraverseInOrder()
    {
        TraverseInOrderRec(root);
    }

    private void TraverseInOrderRec(Node root)
    {
        if (root != null)
        {
            TraverseInOrderRec(root.Left);
            Console.WriteLine($"Giá trị: {root.Data}, Số lần xuất hiện: {root.Count}");
            TraverseInOrderRec(root.Right);
        }
    }

    // Hàm đếm số nút trong cây
    private int CountNodes(Node root)
    {
        if (root == null)
            return 0;
        return 1 + CountNodes(root.Left) + CountNodes(root.Right);
    }

    // Hàm đếm số cạnh trong cây
    public int CountEdges()
    {
        int nodeCount = CountNodes(root);
        return nodeCount > 0 ? nodeCount - 1 : 0;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        BinarySearchTree bst = new BinarySearchTree();
        Random random = new Random();

        for (int i = 0; i < 10000; i++)
        {
            bst.Insert(random.Next(0, 10));
        }

        Console.WriteLine("Kết quả duyệt cây (Inorder Traversal):");
        bst.TraverseInOrder();

        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine($"Số cạnh trên cây: {bst.CountEdges()}");
    }
}
