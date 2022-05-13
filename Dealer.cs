using System.ComponentModel.DataAnnotations;

namespace Hilo;

public class Dealer
{
    private Random _random;
    private bool keepPlaying;
    private int currentCard;
    private int oldCard;
    private Player player;
    private int score;
    private string guess;

    public Dealer()
    {
        player = new Player();
        _random = new Random();
        keepPlaying = true;
        currentCard = _random.Next(13) + 1;
        score = 300;
        guess = "h";
    }

    public void GameLoop()
    {
        while (keepPlaying)
        {
            DisplayCurrentCard();
            guess = player.GuessHilo();
            DisplayNextCard();
            CalculateScore();
            DisplayScore();
            keepPlaying = (score <= 0) ? false : player.KeepPlaying();
            Console.WriteLine();
        }
    }

    private void DrawCard()
    {
        currentCard = _random.Next(13) + 1;
    }

    private void DisplayCurrentCard()
    {
        Console.WriteLine($"The card is: {currentCard}");
    }

    private void DisplayNextCard()
    {
        oldCard = currentCard;
        DrawCard();
        Console.WriteLine($"Next card was: {currentCard}");
    }

    private void CalculateScore()
    {
        if (currentCard > oldCard && guess == "h")
        {
            score += 100;
        } else if (currentCard < oldCard && guess == "l")
        {
            score += 100;
        }
        else
        {
            score -= 75;
        }
    }

    private void DisplayScore()
    {
        Console.WriteLine($"Your score is: {score}");
    }

}