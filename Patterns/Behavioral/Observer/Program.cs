// Observer
// Реализует у класса механизм, который позволяет объекту этого класса получать оповещения об изменении состояния других объектов и тем самым наблюдать за ними.

var footballGame = new FootballGame();
var team1Fan = new Team1Fan("Boris", footballGame);
var team2Fan = new Team2Fan("Mike", footballGame);

footballGame.StartGame(); // Imitate game
team1Fan.StopWatching(); // fan1 leaves stadium
footballGame.StartGame(); // Continue to imitate game
team2Fan.StopWatching(); // fan2 leaves stadium
footballGame.StartGame(); // Continue to imitate game
 
internal interface IObserver
{
    void Update(Object ob);
}
 
internal interface IObservable
{
    void RegisterObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers();
}

internal interface IFootballGame : IObservable
{
    MatchStats CurrentStats { get; }

    void StartGame();
}
 

internal class FootballGame : IFootballGame
{
    private readonly Random rnd;
    private readonly List<IObserver> observers;
    private readonly MatchStats stats;

    public MatchStats CurrentStats => stats;
    
    public FootballGame()
    {
        observers = new List<IObserver>();
        stats = new MatchStats();
        rnd = new Random();
    }

    public void RegisterObserver(IObserver o)
    {
        observers.Add(o);
    }
 
    public void RemoveObserver(IObserver o)
    {
        observers.Remove(o);
    }
 
    public void NotifyObservers()
    {
        if (!observers.Any())
        {
            Console.WriteLine("There is no more football fans here");
            return;
        }
        
        foreach(IObserver o in observers)
        {
            o.Update(stats);
        }
    }

    public void StartGame()
    {
        stats.Team1Score += rnd.Next(0, 4);
        stats.Team2Score += rnd.Next(2, 5);
        NotifyObservers();
    }
}
 
internal class MatchStats
{
    public int Team1Score { get; set; }
    public int Team2Score { get; set; }
}

internal class Team1Fan : IObserver
{
    private IFootballGame? game;

    public string Name { get; }

    public Team1Fan(string name, IFootballGame obs)
    {
        Name = name;
        game = obs;
        game.RegisterObserver(this);
    }

    public void Update(object ob)
    {
        if (game is null)
        {
            Console.WriteLine(
                $"Fan {Name} is speaking: I'm tired of this game.");
        }
        else if (game.CurrentStats.Team1Score > game.CurrentStats.Team2Score)
        {
            Console.WriteLine(
                $"Fan {Name} is speaking: Hail Team1! Current score {game.CurrentStats.Team1Score}:{game.CurrentStats.Team2Score}");
        }
        else
        {
            Console.WriteLine(
                $"Fan {Name} is speaking: Come on, Team1! Be stronger! Current score {game.CurrentStats.Team1Score}:{game.CurrentStats.Team2Score}");
        }
    }

    public void StopWatching()
    {
        Console.WriteLine($"Fan {Name} is leaving stadium");
        game.RemoveObserver(this);
        game = null;
    }
}

internal class Team2Fan : IObserver
{
    private IFootballGame? game;

    public string Name { get; }

    public Team2Fan(string name, IFootballGame obs)
    {
        Name = name;
        game = obs;
        game.RegisterObserver(this);
    }

    public void Update(object ob)
    {
        if (game is null)
        {
            Console.WriteLine(
                $"Fan {Name} is speaking: I'm tired of this game.");
        }
        else if (game.CurrentStats.Team1Score < game.CurrentStats.Team2Score)
        {
            Console.WriteLine(
                $"Fan {Name} is speaking: Hail Team2! Current score {game.CurrentStats.Team1Score}:{game.CurrentStats.Team2Score}");
        }
        else
        {
            Console.WriteLine(
                $"Fan {Name} is speaking: Come on, Team2! Be stronger! Current score {game.CurrentStats.Team1Score}:{game.CurrentStats.Team2Score}");
        }
    }

    public void StopWatching()
    {
        Console.WriteLine($"Fan {Name} is leaving stadium");
        game.RemoveObserver(this);
        game = null;
    }
}