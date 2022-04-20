namespace H1_Rugby
{
     internal class Tools
    {
        private static int counter;
        internal void PrintArray(string[] input )
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("|---------|-----------|");
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i] + " " );
            }
            Console.WriteLine("|---------|-----------|");
            while (counter < input.Length)
            {
                Console.WriteLine(input[counter]);
                counter++;
            }
            Console.WriteLine("|_________|___________|");

        }
    }
}
