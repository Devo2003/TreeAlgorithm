using System;
namespace Trees
{
	public class BinaryTree
	{
        public TreeNode Root { get; set; }

        public BinaryTree()
		{
            Root = null;
        }
        //this method inserts a value to the tree
        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }
        
        private TreeNode InsertRec(TreeNode root, int value)
        {
            //Creates a new node with a value only if a root comes back null
            if (root == null)
            {
                return new TreeNode(value);
            }
            //if the value is less than the current root this will insert the nodes value to the left side of the tree instead
            if (value < root.Value)
            {
                root.LeftChild = InsertRec(root.LeftChild, value);
            }
            //if the value is greater this will insert the nodes value to the right side of the tree 
            else if (value > root.Value)
            {
                root.RightChild = InsertRec(root.RightChild, value);
            }

            return root;
        }
        //this orders the values in a In order traversal way
        public void InOrderTraversal(TreeNode root)
        {
            if (root != null)
            {
                //Traverses through the left side of the tree and then the right side 
                InOrderTraversal(root.LeftChild);
                //prints the value of the node to the console
                Console.Write(root.Value + " ");
                InOrderTraversal(root.RightChild);
            }
        }
    }

}


