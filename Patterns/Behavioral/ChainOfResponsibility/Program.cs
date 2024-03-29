﻿// Chain of responsibility
// Поведенческий шаблон проектирования, позволяющий избежать привязки отправителя запроса к его получателю,
// разрешая обработать запрос нескольким объектам.
// Связывает объекты-получатели в цепочку и передает запрос следующему по цепочке обработчику.

var handler1 = new LessThanTenHandler(); // < 10
var handler2 = new BetweenTenAndTwentyHandler(); // 10..20
var handler3 = new MoreThanOrEqualTwentyHandler(); // 21..
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

internal class MoreThanOrEqualTwentyHandler : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 20)
        {
            Console.WriteLine($"{nameof(MoreThanOrEqualTwentyHandler)} handled the request {request}");
        }
        else if (successor is not null)
        {
            successor.HandleRequest(request);
        }
    }
}