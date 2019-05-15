using System;

namespace GoogleSheetAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Display();
        }

        public static void Display()
        {
            Service.GetConnection();
            Service.CreateEntry();
            Service.UpdateEntry();
            Service.DeleteEntry();

            var data = Service.ReadEntries();

            if (data != null)
            {
                foreach (var row in data)
                {
                    Console.WriteLine("{0} | {1} | {2}", row[0], row[1], row[2]);
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }

            Console.Read();
        }
    }
}
