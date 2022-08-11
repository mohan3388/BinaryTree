namespace BinaryTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Binary Search Tree");
            Binary<int> binarysearch = new Binary<int>(56);
            binarysearch.Insert(30);
            binarysearch.Insert(70);
            binarysearch.Display();

        }
    }
}