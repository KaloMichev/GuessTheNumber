Random rnd = new Random();
int number = rnd.Next(1, 101);

while (true)
{
    Console.Write($"Guess a number (1-100): ");
    string input = Console.ReadLine();
    bool isValid = int.TryParse(input, out int playerNum);
    if (isValid)
    {
        if (playerNum == number)
        {
            Console.WriteLine("You guessed it!");
            break;
        }
        else if (playerNum > number)
        {
            Console.WriteLine("Too high!");
        }
        else if (playerNum < number)
        {
            Console.WriteLine("Too low!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
    
}
