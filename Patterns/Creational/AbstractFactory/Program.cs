// Abstract Factory
// Порождающий шаблон проектирования, предоставляет интерфейс для создания семейств взаимосвязанных или взаимозависимых объектов, не специфицируя их конкретных классов.
// Шаблон реализуется созданием абстрактного класса Factory, который представляет собой интерфейс для создания компонентов системы.
// Затем пишутся классы, реализующие этот интерфейс

var car = new Vehicle(new CarFactory());
car.StartEngine();
car.StartMoving();
        
var plane = new Vehicle(new AircraftFactory());
plane.StartEngine();
plane.StartMoving();

abstract class Engine
{
    public abstract void Start();
}

abstract class MovementType
{
    public abstract void Move();
}
 
internal class AutomotiveEngine : Engine
{
    public override void Start()
    {
        Console.WriteLine("Start the automotive engine");
    }
}

internal class AircraftEngine : Engine
{
    public override void Start()
    {
        Console.WriteLine("Start the aircraft engine");
    }
}

internal class FlyMovementType : MovementType
{
    public override void Move()
    {
        Console.WriteLine("Let's fly!");
    }
}

internal class RideMovementType : MovementType
{
    public override void Move()
    {
        Console.WriteLine("Let's ride!");
    }
}

internal abstract class VehicleFactory // Abstract factory
{
    public abstract Engine CreateEngine();
    
    public abstract MovementType CreateMovementType();
}

internal class CarFactory : VehicleFactory // Concrete factory
{
    public override MovementType CreateMovementType() => new RideMovementType();

    public override Engine CreateEngine() => new  AutomotiveEngine();
}

internal class AircraftFactory : VehicleFactory // Concrete factory
{
    public override MovementType CreateMovementType() => new FlyMovementType();

    public override Engine CreateEngine() => new AircraftEngine();
}

internal class Vehicle // Client
{
    private Engine engine;
    private MovementType movementType;

    public Vehicle(VehicleFactory factory)
    {
        engine = factory.CreateEngine();
        movementType = factory.CreateMovementType();
    }

    public void StartEngine()
    {
        engine.Start();
    }

    public void StartMoving()
    {
        movementType.Move();
    }
}