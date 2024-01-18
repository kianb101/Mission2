using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");
        int rolls = int.Parse(Console.ReadLine());

        DiceRoller diceRoller = new DiceRoller();
        int[] results = diceRoller.RollDice(rolls);

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {rolls}.");

        for (int i = 2; i <= 12; i++)
        {
            Console.Write($"{i}: ");
            int percentage = (int)Math.Round((double)results[i] / rolls * 100);
            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}

internal class DiceRoller
{
    private Random random = new Random();

    public int[] RollDice(int rolls)
    {
        int[] results = new int[13];
        for (int i = 0; i < rolls; i++)
        {
            int roll = random.Next(1, 7) + random.Next(1, 7);
            results[roll]++;
        }
        return results;
    }
}
