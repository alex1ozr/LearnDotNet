// State
// Поведенческий шаблон проектирования, позволяющий объекту изменять свое поведение в зависимости от текущего внутреннего состояния состояния.

var printer = new Printer(new ReadyForPrintState());
printer.Cancel();
printer.ContinueProcess();
printer.ContinueProcess();
printer.Cancel();

internal class Printer
{
    public IPrinterState State { get; set; }
 
    public Printer(IPrinterState state)
    {
        State = state;
    }
 
    public void ContinueProcess() => State.Handle(this);

    public void Cancel() => State.Cancel(this);
}
 
internal interface IPrinterState
{
    void Handle(Printer printer);

    void Cancel(Printer printer);
}

internal class ReadyForPrintState: IPrinterState
{
    public void Handle(Printer printer)
    {
        Console.WriteLine("Printer is ready");
        printer.State = new StartPrintingState();
    }

    public void Cancel(Printer printer)
    {
        Console.WriteLine("Printer is ready. Nothing to cancel");
    }
}

internal class StartPrintingState: IPrinterState
{
    public void Handle(Printer printer)
    {
        Console.WriteLine("Printer is preparing for print");
        printer.State = new PrintingInProgressState();
    }

    public void Cancel(Printer printer)
    {
        Console.WriteLine("Printer is preparing for print. Cancelling current operation..");
        printer.State = new ReadyForPrintState();
    }
}

internal class PrintingInProgressState: IPrinterState
{
    public void Handle(Printer printer)
    {
        Console.WriteLine("Printer is printing now");
    }

    public void Cancel(Printer printer)
    {
        Console.WriteLine("Printer is printing now. Cancelling current operation..");
    }
}

internal class PrintingFinishedState: IPrinterState
{
    public void Handle(Printer printer)
    {
        Console.WriteLine("Printer has finished printing");
        printer.State = new ReadyForPrintState();
    }

    public void Cancel(Printer printer)
    {
        Console.WriteLine("Printer has finished printing. Nothing to cancel");
    }
}