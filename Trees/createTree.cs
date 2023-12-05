//NOTE: this class doesnt create the tree just coverts the file into elements within the array
using System;
namespace Trees
{
    public class createTree
    {
        public int[] Nums;
        public string[] fileLines;
        public string fileDirectory;

       

        public createTree()
        {
            //this line gives in the path of the file into a string
            fileDirectory = "/Users/devinsalgado35/Desktop/TreeAlgorithm/Trees/scores.txt";
            Nums = fileCovertToArray(fileDirectory);
        }

        public int[] fileCovertToArray(string fileDirectory)
        {
            fileLines = File.ReadAllLines(fileDirectory);

            Nums = new int[fileLines.Length];
            
            for (int i = 0; i < fileLines.Length; i++)
            {
                if (int.TryParse(fileLines[i], out int value))
                {
                    Nums[i] = value;
                }
            }
            return Nums;
        }

        public void printArray(int[] Nums)
        {
            foreach (var item in Nums)
            {
                Console.WriteLine(item);
            }
        }


        //NOTE: This is not needed for the assignment since the Binary Tree already sorts the items in the array

        // Name: BubbleSort Algorithm
        // Description:
        // O(n^2) average and worst case

        public void BubbleSort(int[] data)
        {
            for (int i = 0; i < Nums.Length; i++)
            {
                for (int j = 0; j < Nums.Length - 1; j++)
                {
                    if (Nums[j] > Nums[j + 1])
                    {
                        int temp = Nums[j];
                        Nums[j] = Nums[j + 1];
                        Nums[j + 1] = temp;
                        //printArray(Nums);

                    }
                }
            }
            printArray(Nums);
        }
    }
}


