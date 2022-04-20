namespace H1_List
{
    internal class List
    {

        List<object> list = new List<object>() { "one", "two"};

        void AddToList()
        {
            list.Add("Three");
        }

        void Printlist()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        
        public static List<string> Rugbyplayerlist()
        {
            List<string> RugbySpiller = new List<string>();
            RugbySpiller.Add("Zinzan Brooke");
            RugbySpiller.Add("Gareth Edwards");
            RugbySpiller.Add("Jonny Wilkinson");
            RugbySpiller.Add("Martin Johnson");
            RugbySpiller.Add("Jonah Lomu");

            return RugbySpiller;
        }
    }
}
