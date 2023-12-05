// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace Trees
{
    class Program
    {
        static void Main()
        {
            createTree ct = new createTree();

            string fileDirectory = "/Users/devinsalgado35/Desktop/TreeAlgorithm/Trees/scores.txt";
            int[] data = ct.fileCovertToArray(fileDirectory);


            ct.BubbleSort(data);
            Console.ReadKey();
        }
    }
}

