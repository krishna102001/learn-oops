public class Program
{
    public static void Main()
    {
        int[] num = { 1, 2, 3, 4, 5, 6 };
        int[6] prefixsum;
        int sum = 0
        for (int i = 0; i < num.Length(); i++)
        {
            sum = sum + num[i];
            prefixsum[i] = sum;
        }
        Console.WriteLine(prefixsum);
    }
}