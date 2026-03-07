using System.Collections.Immutable;
using System.Globalization;
using System.Net;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// 
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        double[] results = new double[length]; //create new array for storing the results
        for (var num = 0; num < length; num++) // loops until the 'length' size given is reached 
        {
            results[num] = Math.Round(number * (num + 1), 10); // multiply 'number' by each number inside the 'length' size given, rounds the result and stores it in the array
        }
        return results; // returns the result as an array of doubles
    }
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        List<int> slice = new List<int>(); //create new list for storing the split values

        int split = data.Count - amount; // find the index you should split the list (6 = 9 - 3)
        slice = data.GetRange(split, amount); // separates the indexes of the list that should be moved to the front and stores it in the list (after 6 it selects the amount of 3 (7,8,9))
        data.RemoveRange(split, amount); // remove the sliced values from the original list (- 7,8,9)
        data.InsertRange(0, slice); // insert these sliced values at the beginning of the list (7,8,9,1,2,3,4,5,6)
    }
}
