namespace day03a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"C:\Users\berki\src\csharp\AoC-2022\day03a\data.txt");

            List<string> firstComp = new List<string>();
            List<string> secondComp = new List<string>();

            int counter = 0;
            foreach (string row in input.Split("\r\n"))
            {
                firstComp.Add(row.Substring(0, row.Length / 2));
                secondComp.Add(row.Substring(firstComp[counter].Length, row.Length / 2));
                Console.WriteLine(firstComp[counter]);
                Console.WriteLine(secondComp[counter]);
                counter++;
            }
            Console.ReadLine();
        }
    }
}