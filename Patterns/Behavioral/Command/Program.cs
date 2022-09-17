// Command

var phoneMarket = new PhoneMarket();
var iphone = new Phone("iPhone", 777);
phoneMarket.Execute(new IncreasePriceCommand(iphone, 223));
phoneMarket.Execute(new IncreasePriceCommand(iphone, 1000));
phoneMarket.UndoLastCommand();
phoneMarket.Execute(new DecreasePriceCommand(iphone, 200));

internal interface ICommand
{
    void Execute();
    
    void Undo();
}
 
internal class Phone
{
    private int price;

    public string Name { get; }
    public int Price => price;

    public Phone(string name, int initialPrice)
    {
        price = initialPrice;
        Name = name;
    }
    
    public void IncreasePrice(int amount)
    {
        price += amount;
        Console.WriteLine($"{Name} price increased! Current price is {price}");
    }

    public void DecreasePrice(int amount)
    {
        if (amount > price)
        {
            price = 0;
        }
        else
        {
            price -= amount;
        }

        Console.WriteLine($"{Name} price decreased! Current price is {price}");
    }
}
 
internal class IncreasePriceCommand : ICommand
{
    private readonly Phone phone;
    private readonly int amount;

    public IncreasePriceCommand(Phone phone, int amount)
    {
        this.phone = phone;
        this.amount = amount;
    }
    public void Execute()
    {
        Console.WriteLine($"{nameof(IncreasePriceCommand)} was invoked for {phone.Name} with amount = {amount}");
        phone.IncreasePrice(amount);
    }
    public void Undo()
    {
        Console.WriteLine($"Undo {nameof(IncreasePriceCommand)} was invoked for {phone.Name} with amount = {amount}");
        phone.DecreasePrice(amount);
    }
}

internal class DecreasePriceCommand : ICommand
{
    private readonly Phone phone;
    private readonly int amount;

    public DecreasePriceCommand(Phone phone, int amount)
    {
        this.phone = phone;
        this.amount = amount;
    }
    public void Execute()
    {
        Console.WriteLine($"{nameof(DecreasePriceCommand)} was invoked for {phone.Name} with amount = {amount}");
        phone.DecreasePrice(amount);
    }
    public void Undo()
    {
        Console.WriteLine($"Undo {nameof(DecreasePriceCommand)} was invoked for {phone.Name} with amount = {amount}");
        phone.IncreasePrice(amount);
    }
}

internal class PhoneMarket
{
    private readonly Stack<ICommand> commandsHistory;
    private ICommand command;

    public PhoneMarket()
    {
        commandsHistory = new Stack<ICommand>();
    }

    public void Execute(ICommand productCommand)
    {
        SetCommand(productCommand);
        InvokeCurrentCommand();
    }

    public void UndoLastCommand()
    {
        if (commandsHistory.Any())
        {
            var command = commandsHistory.Pop();
            command.Undo();
        }
    }
    
    private void SetCommand(ICommand command) => this.command = command;

    private void InvokeCurrentCommand()
    {
        commandsHistory.Push(command);
        command.Execute();
    }
}