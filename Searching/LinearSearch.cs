using System;
namespace Array
{
    class SearchingAlgo
    {
        static int LinearSearch(int[] array, int target)
        {
            int i = 0;
            while (i < array.Length)
            {
                if (array[i] == target)
                    return i + 1;
                i++;
            }
            return -1;
        }
        static void Main()
        {
            int target, searchresult, size;
            Console.Write("Enter size of array:");
            size = int.Parse(Console.ReadLine());
            int[] data = new int[size];
            int j = 0;
            while (j < data.Length)
            {
                Console.Write("Element {0}: ", j + 1);
                data[j] = int.Parse(Console.ReadLine());
                j++;
            }
            Console.Write("Array is { ");
            int i = 0;
            while (i < data.Length)
            {
                Console.Write(data[i] + " ");
                i++;
            }
            Console.Write(" }");
            Console.WriteLine();
            Console.WriteLine("Enter element to search");
            target = int.Parse(Console.ReadLine());
            searchresult = LinearSearch(data, target);
            if (searchresult != -1)
            {
                Console.WriteLine("Element {0} is found at {1} position", target, searchresult);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}

/*-------------OUTPUT------------------
 Enter size of array:5
Element 1: 7
Element 2: 9
Element 3: 6
Element 4: 1
Element 5: 3
Array is { 7 9 6 1 3  }
Enter element to search
1
Element 1 is found at 4 position
 */
