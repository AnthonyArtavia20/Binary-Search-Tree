using BSTProgram;

public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree ejemplo = new BinarySearchTree();

        ejemplo.insert(5);
        ejemplo.insert(1);
        ejemplo.insert(2);
        ejemplo.insert(4);
        ejemplo.insert(3);

        Console.WriteLine("InOrder: ");
        ejemplo.inOrder();
        Console.WriteLine("PreOrder: ");
        ejemplo.preOrder();
        Console.WriteLine("PostOrder: ");
        ejemplo.postOrder();
    }
}