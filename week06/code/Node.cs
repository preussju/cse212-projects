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
        // TODO Start Problem 1

        if (value == Data)
            return; // no duplicates
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (Data == 0) //base case 
            return false;
        else if (value == Data) //if exists 
            return true;
        else if (value < Data) 
        {
            if (Left is null) //if left is null, does not exist
                return false;
            else
                return Left.Contains(value); //search left subtree
        }
        else
        {
            if (Right is null) //if right is null, does not exist
                return false;
            else
                return Right.Contains(value); //search right subtree
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        return 0; // Replace this line with the correct return statement(s)
    }
}