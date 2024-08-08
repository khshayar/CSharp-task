namespace ConsoleApp1;

public class GameClub
{
    //player 
    //games
    public string Name { get; }
    private List<Game> _games;
    private string UserName { get; set; }
    public GameClub(string name ,params Game[]games)
    {
        Name = name;
        _games = games.ToList();
    }

    public void User(string name)
    {
        UserName = name;
        menue();
        

    }

    private void menue()
    {
        Console.WriteLine($"wellcom to{Name} game club");
        Console.WriteLine(" 1 : play ");
        Console.WriteLine(" 2 : pay ");
        var number = Console.ReadLine();
        switch (number)
        {
            case "1" :
                GameMenue();
                break;
            case "2":
                Pay();
                break;
            default:
                Console.WriteLine("good bye ");
                break;
            
        }
    }

    private void GameMenue()
    {
        Console.WriteLine("which game do you wan to paly ");
        for (int i = 0; i < _games.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {_games[i]}");
        }

        int chice = int.Parse(Console.ReadLine());
        Run (_games[chice-1]);
    }

    private void Run(Game game)
    {
        game.Play();
    }
    private void Pay()
    {
        Console.WriteLine("its free !!");
    }
}