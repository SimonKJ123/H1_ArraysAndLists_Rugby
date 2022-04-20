namespace H1_ArraysAndLists
{
    internal static class Skating
    {
        //My First Array
        private static string[] Skatingstuff = new string[5];
        private static int counter;
        public static void AddSkatingStuff() 
        {
            Skatingstuff[0] = "Rulleskøjter";
            Skatingstuff[1] = "Longboard";
            Skatingstuff[2] = "Løbehhjul";
            Skatingstuff[3] = "Skateboard";
            Skatingstuff[4] = "Strygebræt";
            //SkatingStuff[5] = "IsThisEvenPossible"; NO!

        
        }
        //Counter
        internal static void PrintArray()
        {
            foreach (var item in Skatingstuff) 
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < Skatingstuff.Length; i++)
            {
                Console.WriteLine(Skatingstuff[i] + " " + i);
            }
            while (counter < Skatingstuff.Length)
            {
                Console.WriteLine(Skatingstuff[counter]);
                counter++;
            }
                      
        }
    }
}
