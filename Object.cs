using System.Security.Cryptography.X509Certificates;

class Student
{
   public string name;
   public int age;
}
class StudentFactory
{
    public static void Run()
    {
        Student p1 = new Student();
        p1.name = "Utso Roy";
        p1.age = 30;
        Console.WriteLine($"Student Name : {p1.name} age : {p1.age}");

    }
}