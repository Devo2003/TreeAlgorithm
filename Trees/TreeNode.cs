namespace Trees
{
    public class TreeNode
    {
        //This class just creates and is given a value to the fields
        //These are used more in the Binary tree class
        public int Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }


        public TreeNode(int value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;

        }
    }
}