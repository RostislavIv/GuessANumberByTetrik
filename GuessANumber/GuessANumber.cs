Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear();
const int startNum = 1;
const int endNum = 100;
while (true)
{
    Random rnd = new Random();
    int compNum = rnd.Next(startNum, endNum + 1);
    int inpuTimes = 0;
    while (true)
    {
        Console.Write($"Guess a number between {startNum} and {endNum}: ");
        bool isValid = int.TryParse(Console.ReadLine(), out int playerNum);
        if (isValid && startNum <= playerNum && playerNum <= endNum)
        {
            inpuTimes++;
            if (playerNum == compNum)
            {
                Console.WriteLine();
                Console.WriteLine($"You guessed it {inpuTimes} time!");
                Console.WriteLine();
                break;
            }
            else if (playerNum > compNum)
                Console.WriteLine("It is higher");
            else
                Console.WriteLine("It is lower");
        }
        else
            Console.WriteLine("Invalid input. Try again...");
    }
    Console.WriteLine("For new game press \"Y\"");
    Console.WriteLine("For exit press another key");
    if (Console.ReadLine().ToLower() != "y")
        break;
    Console.WriteLine();
}



