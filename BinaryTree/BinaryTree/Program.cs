namespace BinaryTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Binary Search Tree");
            Binary<int> binarysearch = new Binary<int>(56);
            binarysearch.Insert(30);
            binarysearch.Insert(17);
            binarysearch.Insert(51);
            binarysearch.Insert(62);
            binarysearch.Insert(70);
            binarysearch.Display();
            binarysearch.GetSize();
            bool result = binarysearch.IfExists(30, binarysearch);
            Console.WriteLine(result);

        }
    }
}