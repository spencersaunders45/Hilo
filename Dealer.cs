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

    // Selects a random number between 1 and 13
    private void DrawCard()
    {
        currentCard = _random.Next(13) + 1;
    }

    // Displays current number to user
    private void DisplayCurrentCard()
    {
        Console.WriteLine($"The card is: {currentCard}");
    }

    // Moves currentCard value to oldCard value
    // Assigns new value to current card
    // Displays currentCard value to the user
    private void DisplayNextCard()
    {
        oldCard = currentCard;
        DrawCard();
        Console.WriteLine($"Next card was: {currentCard}");
    }

    // Checks if the user guessed high or low correctly
    // Else the user looses points
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

    // Displays user score
    private void DisplayScore()
    {
        Console.WriteLine($"Your score is: {score}");
    }

}