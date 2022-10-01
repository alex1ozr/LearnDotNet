// Builder
// Отделяет конструирование сложного объекта от его представления так,
// что в результате одного и того же процесса конструирования могут получаться разные представления.

var factory = new VehicleFactory();
VehicleBuilder builder;

builder = new CarBuilder();
factory.Construct(builder);
var car = builder.Vehicle;
Console.WriteLine(car.ToString());

builder = new AircraftBuilder();
factory.Construct(builder);
var plane = builder.Vehicle;

Console.WriteLine(plane.ToString());

internal class VehicleFactory // Director class
{
    public void Construct(VehicleBuilder vehicleBuilder)
    {
        vehicleBuilder.BuildBodyType();
        vehicleBuilder.BuildEngine();
        vehicleBuilder.BuildDoors();
    }
}

internal abstract class VehicleBuilder
{
    protected readonly Vehicle vehicle;

    protected VehicleBuilder(Vehicle vehicle)
    {
        this.vehicle = vehicle;
    }
    
    public Vehicle Vehicle => vehicle;

    public abstract void BuildBodyType();
    public abstract void BuildEngine();
    public abstract void BuildDoors();
}

internal class CarBuilder : VehicleBuilder
{
    public CarBuilder()
        : base(new Vehicle("Car"))
    {
    }

    public override void BuildBodyType()
    {
        vehicle.BodyType = "Truck";
    }

    public override void BuildEngine()
    {
        vehicle.Engine = "V8";
    }

    public override void BuildDoors()
    {
        vehicle.Doors = 4;
    }
}

internal class AircraftBuilder : VehicleBuilder
{
    public AircraftBuilder()
        : base(new Vehicle("Aircraft"))
    {
    }

    public override void BuildBodyType()
    {
        vehicle.BodyType = "Plane";
    }

    public override void BuildEngine()
    {
        vehicle.Engine = "V8";
    }

    public override void BuildDoors()
    {
        vehicle.Doors = 2;
    }
}

internal class Vehicle
{
    private readonly string vehicleType;

    public string? BodyType { get; set; }
    public string? Engine { get; set; }
    public int? Doors { get; set; }

    public Vehicle(string vehicleType)
    {
        this.vehicleType = vehicleType;
    }

    public override string ToString() => $"{vehicleType} (BodyType: {BodyType}, Engine: {Engine}, Doors: {Doors})";
}