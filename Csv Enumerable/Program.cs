using System;
using System.Collections;

namespace Csv_Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "file.csv";
            IEnumerable csvEnumerable = new CsvEnumerable(fileName);
            Console.WriteLine($"Iterating csv records in {fileName}");

            foreach (var item in csvEnumerable)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}