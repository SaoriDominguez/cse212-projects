public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN:
        // 1) Create an array of doubles with size = length.
        // 2) For each position i from 0 to length - 1:
        //    - The value should be number * (i + 1)
        //      (because i=0 should give the first multiple: number * 1).
        // 3) Return the filled array.

        var result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
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
        // PLAN:
        // 1) Compute where the "split" happens:
        //    - The last 'amount' items move to the front.
        //    - So splitIndex = data.Count - amount.
        // 2) Copy the last 'amount' items into a temporary list (tail).
        // 3) Remove those last 'amount' items from the original list.
        // 4) Insert the saved tail items at the front of the original list.

        int splitIndex = data.Count - amount;

        List<int> tail = data.GetRange(splitIndex, amount);
        data.RemoveRange(splitIndex, amount);
        data.InsertRange(0, tail);
    }
}
