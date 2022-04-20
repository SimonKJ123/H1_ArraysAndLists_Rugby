namespace H1_List
{
    internal class Tools
    {
        public static int counter;
        public static void PrintArray(List<string> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine(input[i] + " ");
            }
            while (counter < input.Count)
            {
                Console.WriteLine(input[counter]);
                counter++;
            }

        }
    }
}