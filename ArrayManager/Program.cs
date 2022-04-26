{
    ArrayManager array = new();
    array.GetMax(array.Create(7));
    Console.ReadLine();
}
class ArrayManager
{
    #region Create
    public int[] Create(int lenght)
    {
        int[] array = new int[lenght];
        Random random = new();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(10, 100);
            Console.Write(array[i] + " ");
        }
        return array;
    }
    #endregion

    #region Getmax
    public int GetMax(int[]array)
    {
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            Console.WriteLine();
        }
        Console.WriteLine(max);
        return max;
    }
    #endregion
}
