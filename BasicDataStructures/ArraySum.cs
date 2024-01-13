namespace BasicDataStructures;

public class ArraySum
{
    public static void Main()
    {
        var arr = new int[6];
        int i;
        var sum = 0;

        Console.Write("\n\nArray Craze! Write, Read and Print Elements of an Array\n");
        Console.Write("____________________________________________________________\n");

        Console.Write("Input 6 elements for an array :\n");
        for (i = 0; i < 6; i++)
        {
            Console.Write("element - {0} : ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nElements in array are: ");
        for (i = 0; i < 6; i++) Console.Write("{0}  ", arr[i]);

        Console.Write("\n");

        // get the sum of all elements
        for (i = 0; i < arr.Length; i++) sum += arr[i];

        Console.WriteLine("The Sum of array elements: " + sum);

        // get the minimum element
        Console.WriteLine("Smallest  Element: " + arr.Min());

        // Max() returns the largest number in array
        Console.WriteLine("Largest Element: " + arr.Max());

        Console.ReadLine();
        Console.Write("\n");
    }
}