namespace Hilo;

public class Player
{
    public string GuessHilo()
    {
        Console.Write("Higher or lower? [h/l] ");
        string guess = Console.ReadLine();
        return guess;
    }

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