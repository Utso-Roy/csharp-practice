class Students
{
  public  string name;
    public int age;
    public int mark1;
    public int mark2;
    public Students(string n, int a)
    {
        name = n;
        age = a;
        Console.WriteLine($"I am {name}, i am {age} years old");
    }

    public Students ( int m1 , int m2)
    {
       
        mark1 = m1;
        mark2 = m2;
        Console.WriteLine($"sum = {mark1 + mark2}");
        
    }
    
    public void Display(string name , int age)
    {
        Console.WriteLine($"Student Name {name} \n Student age {age}");
    }
}