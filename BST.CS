namespace BSTProgram
{
    public class BinarySearchTree {
        TreeNode? root;

        public BinarySearchTree() 
        {
            root = null;
        }

        public bool search(int key) 
        {
            return searchRecursive(root, key);
        }

        private bool searchRecursive(TreeNode? root, int key) 
        {
            if (root == null || root.key == key)
                return root != null;

            if (root.key < key)
                return searchRecursive(root.right, key);

            return searchRecursive(root.left, key);
        }

        public void insert(int key) 
        {
            root = insertRecursive(root, key);
        }

        private TreeNode insertRecursive(TreeNode? root, int key) 
        {
            if (root == null) {
                root = new TreeNode(key);
                return root;
            }

            if (key < root.key)
                root.left = insertRecursive(root.left, key);
            else if (key > root.key)
                root.right = insertRecursive(root.right, key);

            return root;
        }

        public void inOrder() 
        {
            inOrderRecursive(root);
        }

        private void inOrderRecursive(TreeNode? root) 
        {
            if (root != null) {
                inOrderRecursive(root.left);
                Console.WriteLine(root.key + " ");
                inOrderRecursive(root.right);
            }
        }

        public void preOrder() 
        {
            preOrderRecursive(root);
        }

        private void preOrderRecursive(TreeNode? root) 
        {
            if (root != null) {
                Console.WriteLine(root.key + " ");
                preOrderRecursive(root.left);
                preOrderRecursive(root.right);
            }
        }

        public void postOrder() 
        {
            postOrderRecursive(root);
        }

        private void postOrderRecursive(TreeNode? root) 
        {
            if (root != null) {
                postOrderRecursive(root.left);
                postOrderRecursive(root.right);
                Console.WriteLine(root.key + " ");
            }
        }
    }
}