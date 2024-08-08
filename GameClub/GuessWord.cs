using System.ComponentModel.Design;

namespace ConsoleApp1;

public class GuessWord :Game
{
    public string Guess { get; set; }
    private string _word;
    public override string Name { get; }
    public override string Description { get; }

    public GuessWord(string  Word)
    {
        _word = Word;
        Name = "this is Guess game";
        Description = "this is funny game";
    }

    public override void Play()
    {
        Console.WriteLine("welcome to the Guess word Game");
        Console.WriteLine("1 : play game ");
        Console.WriteLine("2 :exit ");
        var number = Console.ReadLine();
        switch (number)
        {
            case "1":
                start();
                break;
            case "2":
                return;
            default:
                Console.WriteLine("you enter wrong number ");
                break;
        }
    }

    void start()
    {
        Get();
        Check();
    }

    void Get()
    {
        Console.WriteLine("enter your word");
        Guess = Console.ReadLine();
    }

    void Check()
    {
        if (Guess==_word)
        {
            Console.WriteLine("you win ");
            Play();
        }
        else
        {
            Console.WriteLine("you lose");
            Play();
        }
    }
}