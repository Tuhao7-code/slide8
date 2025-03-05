using System;

class Node
{
    public int Data;
    public Node Left, Right;
    
    public Node(int data)
    {
        Data = data;
        Left = Right = null;
    }
}

class BinarySearchTree
{
  // Bài 2
public int CountEdges()
{
    return CountNodes(Root) - 1;
}

private int CountNodes(Node root)
{
    if (root == null)
        return 0;
    return 1 + CountNodes(root.Left) + CountNodes(root.Right);
}
  
    public Node Root;
  

    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }


    private Node InsertRec(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    public void InOrderTraversal(Node root)
    {
        if (root != null)
        {
            InOrderTraversal(root.Left);
            Console.Write(root.Data + " ");
            InOrderTraversal(root.Right);
        }
    }

    public void CountOccurrences(Node root, int[] count)
    {
        if (root != null)
        {
            CountOccurrences(root.Left, count);
            count[root.Data]++;
            CountOccurrences(root.Right, count);
        }
    }

}
class Program
{
    static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();
        Random rand = new Random();
        int[] count = new int[10]; // Mảng đếm số lần xuất hiện của từng số từ 0-9

        // Chèn 10.000 số ngẫu nhiên vào cây
        for (int i = 0; i < 10000; i++)
        {
            int num = rand.Next(0, 10);
            bst.Insert(num);
        }

        // In cây theo thứ tự LNR
        Console.WriteLine("Duyệt cây theo thứ tự LNR:");
        bst.InOrderTraversal(bst.Root);
        Console.WriteLine();

        // Đếm số lần xuất hiện
        bst.CountOccurrences(bst.Root, count);
        Console.WriteLine("\nSố lần xuất hiện của từng số:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Số {i}: {count[i]} lần");
        }
    }
}

class Program
{
    static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();
        Random rand = new Random();
        int[] count = new int[10]
          
        for (int i = 0; i < 10000; i++)
        {
            int num = rand.Next(0, 10);
            bst.Insert(num);
        }

        Console.WriteLine("Duyệt cây theo thứ tự LNR:");
        bst.InOrderTraversal(bst.Root);
        Console.WriteLine();

        bst.CountOccurrences(bst.Root, count);
        Console.WriteLine("\nSố lần xuất hiện của từng số:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Số {i}: {count[i]} lần");
        }
    }
}





