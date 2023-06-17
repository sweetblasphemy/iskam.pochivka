
namespace iskam.pochivka
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            string[] numbers = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            Array.Sort(array);

            int[] result = new int[n];
            int left = 0;
            int right = n - 1;

            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                {
                    result[i] = array[left];
                    left++;
                }
                else
                {
                    result[i] = array[right];
                    right--;
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}