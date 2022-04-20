namespace H1_ArraysAndLists
{
    internal static class Skating
    {
        ////Teachers Array & List

        //List<object> list = new List<object>() { "one", "two" , 3};

        //object[] objArr = new object[3];

        //void AddToList()
        //{
        //    list.Add("Three");
        //}

        //void Printlist()
        //{
        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}


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
