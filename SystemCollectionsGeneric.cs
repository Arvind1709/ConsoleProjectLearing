namespace ConsoleProjectLearing
{
    internal class SystemCollectionsGeneric
    {
        public void IEnumerableICollectionIList()
        {
            IEnumerable<int> numbers = new List<int> { 1, 2, 3 };


            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            ICollection<string> names = new List<string>();
            names.Add("Arvind0");
            names.Add("Arvind1");
            names.Add("Arvind2");
            //names.Remove("Arvind");
            var test = names.Take(2);
            names.ToList();

            Console.WriteLine(names.Count);
            Console.WriteLine(test);
            Console.WriteLine(names.ToList());


            IList<string> cities = new List<string>();
            cities.Add("Delhi");
            cities.Insert(0, "Mumbai");
            cities.Remove("Delhi");
            cities.RemoveAt(0); // Remove the first element
            cities.Clear();

            Console.WriteLine(cities[1]);
        }
    }
}
