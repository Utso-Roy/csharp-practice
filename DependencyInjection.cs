public interface IEngine 
{
    void Start();
}

public class V8Engine : IEngine 
{
    public void Start() 
    {
        Console.WriteLine("V8 Engine started!");
    }
}

public class Car 
{
    private readonly IEngine _engine;

    // (Constructor Injection)
    public Car(IEngine engine) 
    {
        _engine = engine;
    }

    public void Drive() 
    {
        _engine.Start();
    }
}

