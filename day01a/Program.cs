namespace day01a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"textd1.txt");

            int max = 0;

            foreach (var row in input.Split("\n\r"))
            {
                int groupsum = 0;

                foreach (var calorie in row.Split("\r"))
                {
                    Int32.TryParse(calorie, out int lol);
                    groupsum += lol;
                }

                if (groupsum > max)
                {
                    max = groupsum;

                    Console.WriteLine(max);
                }
            }
            Console.WriteLine(max);
        }
    }
}