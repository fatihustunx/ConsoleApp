namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();

            myList.Add("Fatih");

            Console.WriteLine(myList.Length);

            myList.Add("Engin");

            Console.WriteLine(myList.Length);

            foreach (var item in myList.Items) {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            Dictionary<int,string> ogrenciler = new Dictionary<int,string>();
            ogrenciler.Add(1, "Fatih");
            ogrenciler.Add(2, "Engin");

            Console.WriteLine(ogrenciler.Count);

            Console.WriteLine("-------------------------------------");

            MyDictionary<int,string> ogrenciler2 = new MyDictionary<int,string>();
            ogrenciler2.Add(1, "Fatih");
            Console.WriteLine(ogrenciler2.CountKey);
            Console.WriteLine(ogrenciler2.CountValue);
            ogrenciler2.Add(2, "Engin");
            Console.WriteLine(ogrenciler2.CountKey);
            Console.WriteLine(ogrenciler2.CountValue);

            foreach(var item in ogrenciler2.Keys) { Console.WriteLine(item); }
            foreach(var item in ogrenciler2.Values) { Console.WriteLine(item); }
        }
    }
}