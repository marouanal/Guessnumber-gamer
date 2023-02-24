Random random = new Random();
bool PlayAgain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
string response;

while (PlayAgain)
{
    guess = 0;
    guesses = 0;
    number = random.Next(min, max + 1);
    response = ("");

    while (guess != number)
    {
        Console.WriteLine("guess a number between" + min + "-" + max + ":");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("guess :" + guess);

        if (guess > number)
        {
            Console.WriteLine("too high buddy");

        }
        else if (guess < number)
        {
            Console.WriteLine("too low buddyy");
        }
        guesses++;
    }
    Console.WriteLine("number" + number);
    Console.WriteLine("you win buddy");
    Console.WriteLine("guesses" + guesses);
    Console.WriteLine("would you play again buddy");

    response = Console.ReadLine();
    response = response.ToUpper();

    if(response== "Y")

    {
        PlayAgain = true;

    }
    else
    {
        PlayAgain = false;
    }

}






