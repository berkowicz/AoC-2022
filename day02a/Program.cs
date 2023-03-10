namespace day02a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"data.txt");

            int playerOne = 0;
            int playerTwo = 0;

            int win = 6;
            int draw = 3;
            int loose = 0;

            int rock = 1; //A & X
            int paper = 2; //B & Y
            int scissor = 3; //C & Z

            List<string> moves = new List<string>();

            foreach (var row in input.Split("\n"))
            {
                moves.Add(Char.ToString(row[0]) + Char.ToString(row[2]));
            }
            for (int i = 0; i < moves.Count; i++)
            {
                switch (moves[i])
                {
                    case "AX":
                        playerOne += draw + rock;
                        playerTwo += draw + rock;
                        break;
                    case "AY":
                        playerOne += loose + rock;
                        playerTwo += win + paper;
                        break;
                    case "AZ":
                        playerOne += win + rock;
                        playerTwo += loose + scissor;
                        break;
                    case "BX":
                        playerOne += win + paper;
                        playerTwo += loose + rock;
                        break;
                    case "BY":
                        playerOne += draw + paper;
                        playerTwo += draw + paper;
                        break;
                    case "BZ":
                        playerOne += loose + paper;
                        playerTwo += win + scissor;
                        break;
                    case "CX":
                        playerOne += loose + scissor;
                        playerTwo += win + rock;
                        break;
                    case "CY":
                        playerOne += win + scissor;
                        playerTwo += loose + paper;
                        break;
                    case "CZ":
                        playerOne += draw + scissor;
                        playerTwo += draw + scissor;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(playerTwo);
            Console.ReadLine();
        }
    }
}