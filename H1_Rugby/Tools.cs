namespace H1_Rugby
{
     internal class Tools
    {
        private static int counter;
        internal static void PrintArray(string[] input )
        {
            foreach (var item in RugbySpiller)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < RugbySpiller.Length; i++)
            {
                Console.WriteLine(RugbySpiller[i] + " " + i);
            }
            while (counter < RugbySpiller.Length)
            {
                Console.WriteLine(RugbySpiller[counter]);
                counter++;
            }

        }
    }
}
