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
        // Step 1: Create an array of size 'length' to store the multiples.
        // Step 2: Loop from 0 to length-1.
        // Step 3: For each index i, calculate the multiple as number * (i + 1).
        // Step 4: Store the result in the array at index i.
        // Step 5: After the loop, return the array.

        double[] result = new double[length];
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
        // Step 1: Determine the number of elements to move from the end to the front (amount).
        // Step 2: Use GetRange to get the last 'amount' elements.
        // Step 3: Remove those elements from the end of the list.
        // Step 4: Insert the removed elements at the beginning of the list using InsertRange.
        // Step 5: The list is now rotated to the right by 'amount'.

        if (data == null || data.Count == 0 || amount <= 0 || amount > data.Count)
            return;

        List<int> toMove = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, toMove);
    }
}
