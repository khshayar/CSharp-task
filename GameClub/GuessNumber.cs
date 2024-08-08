using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1;

public class GuessNumber : Game
{
    private int _randomNumber;
    public int Guess { get; set; }
    private int _counter = 1;
    

    public GuessNumber()
    {
         Name = "Guse number";
         Description = "this is afunny game";
        Random random = new Random();
        _randomNumber = random.Next(0,100);
    }
    public override string Name { get; }
    public override string Description { get; }

    public override void Play()
    {
        Console.WriteLine(" Guess Number Game ");
        Console.WriteLine(" 1: play game ");
        Console.WriteLine(" 2. exit game");
        var number = Console.ReadLine();
        switch (number)
        {
            case "1":
                Start();
                break;
            case "2":
                return;
            default:
                Console.WriteLine("you enter wrong number !!");
                break;
                
        }
    }

    public void Start()
    {
        GetNumber();
        Check();
        Play();
    }

    private void GetNumber()
    {
        Console.WriteLine("enter your Guess Number ");
        Guess = int.Parse(Console.ReadLine());
    }

    private void Check()
    {
        if (Guess==_randomNumber)
        {
            Console.WriteLine($"you win whit {_counter} try ");
        }
        else
        {
            if (Guess > _randomNumber)
            {
                Console.WriteLine("you Guess is bigger");
                _counter++;
                GetNumber();
                Check();
            }
            else
            {
                Console.WriteLine("you Guess is smaller");
                _counter++;
                GetNumber();
                Check();
                
            }
        }
    }
}