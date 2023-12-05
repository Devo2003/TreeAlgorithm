// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace Trees
{
    class Program
    {
        static void Main()
        {
            createTree ct = new createTree();

            BinaryTree bt = new BinaryTree();

            string fileDirectory = "/Users/devinsalgado35/Desktop/TreeAlgorithm/Trees/scores.txt";
            int[] data = ct.fileCovertToArray(fileDirectory);

            foreach (var value in data)
            {
                bt.Insert(value);
            }

            // Perform in-order traversal to print the sorted values
            Console.WriteLine("In order traversal of binary tree:");
            bt.InOrderTraversal(bt.Root);


            //ct.BubbleSort(data);
            Console.ReadKey();
        }
    }
}

