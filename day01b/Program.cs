namespace day01b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"textd1.txt");

            int first = 0;
            int second = 0;
            int third = 0;

            foreach (var row in input.Split("\n\r"))
            {
                int groupsum = 0;

                foreach (var calorie in row.Split("\r"))
                {
                    Int32.TryParse(calorie, out int lol);
                    groupsum += lol;
                }

                if (groupsum > first)
                {
                    third = second;
                    second = first;
                    first = groupsum;
                }
                else if (groupsum > second)
                {
                    third = second;
                    second = groupsum;
                }
                else if (groupsum > third)
                {
                    third = groupsum;
                }
            }
            int total = first + second + third;
            Console.WriteLine($"first: {first}\nsecond: {second}\nthird: {third}\ntotal: {total}");
        }
    }
}