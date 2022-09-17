// Chain of responsibility

var handler1 = new LessThanTenHandler();
var handler2 = new BetweenTenAndTwentyHandler();
var handler3 = new MoreThanTwentyHandler();
handler1.SetSuccessor(handler2);
handler2.SetSuccessor(handler3);

foreach (int request in new[] { 1, 5, 10, 15, 21 })
{
    handler1.HandleRequest(request);
}


internal abstract class Handler
{
    protected Handler? successor;

    public void SetSuccessor(Handler successor)
    {
        this.successor = successor;
    }

    public abstract void HandleRequest(int request);
}

internal class LessThanTenHandler : Handler
{
    public override void HandleRequest(int request)
    {
        if (request is >= 0 and < 10)
        {
            Console.WriteLine($"{nameof(LessThanTenHandler)} handled the request {request}");
        }
        else if (successor is not null)
        {
            successor.HandleRequest(request);
        }
    }
}

internal class BetweenTenAndTwentyHandler : Handler
{
    public override void HandleRequest(int request)
    {
        if (request is >= 10 and < 20)
        {
            Console.WriteLine($"{nameof(BetweenTenAndTwentyHandler)} handled the request {request}");
        }
        else if (successor is not null)
        {
            successor.HandleRequest(request);
        }
    }
}

internal class MoreThanTwentyHandler : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 20)
        {
            Console.WriteLine($"{nameof(MoreThanTwentyHandler)} handled the request {request}");
        }
        else if (successor is not null)
        {
            successor.HandleRequest(request);
        }
    }
}