namespace ListsDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] arr = { 54, 34, 53, 75, 23, 86, 23, 76, 43, 78, 13 };
            PrintArray(arr);

            List<int> arr1 = arr.Append(2).ToList();

            arr1.Add(3);
            arr1.Add(5);


            string[] arr2 = { "Hello", "World" };

            PrintArray(arr1.ToArray());

            PrintArray(arr2);
                       


        }

        public static void PrintArray<T>(T[] arr)
        {
            foreach (T i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }
}
