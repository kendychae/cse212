public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // If value == Data, do nothing (no duplicates allowed)
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true; // Found the value
        }
        else if (value < Data)
        {
            // Search in the left subtree
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }
        else
        {
            // Search in the right subtree
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // Get the height of left and right subtrees
        int leftHeight = (Left is null) ? 0 : Left.GetHeight();
        int rightHeight = (Right is null) ? 0 : Right.GetHeight();
        
        // Height is 1 plus the maximum of the two subtree heights
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}