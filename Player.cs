namespace Hilo;

public class Player
{
    // Player guesses if card will be higher or lower
    // Returns string
    public string GuessHilo()
    {
        Console.Write("Higher or lower? [h/l] ");
        string guess = Console.ReadLine();
        return guess;
    }

    // Player decieds if they keep playing or not
    // Returns bool
    public bool KeepPlaying()
    {
        Console.Write("Play again? [y/n]");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}