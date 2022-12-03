namespace CollectionsAndConteners
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            Console.WriteLine(list.Count);
            int myInt = 20;
            list.Add(myInt);
            Console.WriteLine(list.Count);

            Console.WriteLine(list[0]);
            Console.WriteLine(list.ElementAt<int>(0));
            try
            {

                Console.WriteLine(list.ElementAt<int>(1)); //Exception - Out of Range
                Console.WriteLine(list[0]); //Exception - Out of Range


            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}