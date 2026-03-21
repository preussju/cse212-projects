/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
        //       (x, y) :            [ 0 left, 1 right, 2 up, 3 down]
        _mazeMap[(1, 1)] = new bool[] { false, true, false, true };
        _mazeMap[(1, 2)] = new bool[] { false, true, true, false };
        _mazeMap[(2, 1)] = new bool[] { true, false, false, true };
        _mazeMap[(2, 2)] = new bool[] { true, false, true, true };
        _mazeMap[(2, 3)] = new bool[] { false, false, true, true };
        _mazeMap[(2, 4)] = new bool[] { true, true, true, false };
        _mazeMap[(1, 4)] = new bool[] { false, true, false, true };
        _mazeMap[(1, 5)] = new bool[] { false, false, true, true };
        _mazeMap[(1, 6)] = new bool[] { false, false, true, false };
        _mazeMap[(3, 4)] = new bool[] { true, true, true, false };
        _mazeMap[(3, 5)] = new bool[] { false, false, true, true };
        _mazeMap[(3, 6)] = new bool[] { false, false, true, false };
        _mazeMap[(4, 4)] = new bool[] { true, true, true, false };
        _mazeMap[(4, 3)] = new bool[] { false, true, false, true };
        _mazeMap[(4, 1)] = new bool[] { false, true, false, false };
        _mazeMap[(5, 4)] = new bool[] { true, false, true, true };
        _mazeMap[(5, 3)] = new bool[] { true, true, true, true };
        _mazeMap[(5, 2)] = new bool[] { false, false, true, true };
        _mazeMap[(5, 1)] = new bool[] { true, true, false, true };
        _mazeMap[(6, 1)] = new bool[] { true, false, false, false };
        _mazeMap[(6, 3)] = new bool[] { true, false, false, false };
        _mazeMap[(5, 5)] = new bool[] { false, false, true, true };
        _mazeMap[(5, 6)] = new bool[] { false, true, true, false };
        _mazeMap[(6, 6)] = new bool[] { true, false, false, false };
    }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        if(_mazeMap.TryGetValue((_currX, _currY), out bool[]values) && values[0])
            _currX -= 1; //moving left means x value -1  
        else
            throw new InvalidOperationException("Can't go that way!");
    }
    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] values) && values[1])
            _currX += 1; //moving right means x value +1
        else
            throw new InvalidOperationException("Can't go that way!");
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] values) && values[2])
            _currY -= 1; //moving up means y value -1
        else
            throw new InvalidOperationException("Can't go that way!");
    }
    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] values) && values[3])
            _currY += 1; //moving down means y value +1
        else
          throw new InvalidOperationException("Can't go that way!");
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}