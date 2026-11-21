using System;

namespace MyConsoleApp.Practice.cs;

public class CopyConstractor
{
    public string Name;
    public int Age = 32;
    public CopyConstractor(string name)
    {
        Name = name;
    }

    public CopyConstractor(CopyConstractor Copy)
    {
        Age = Copy.Age;
        Name = Copy.Name;
    }
}
