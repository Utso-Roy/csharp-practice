using System;
class Test
{
    public static void Main(string[] args)
    {//Constructor
     // StudentFactory.Run();
     // Students p1 = new Students("utso", 23);
     // Students p2 = new Students( 80, 90);
     // p1.Display("Dona Roy",4);

        //Get and set 
        // Bank b1 = new Bank();
        // b1.Name = "Utso Roy";
        //  b1.Amount = 400;
        // Console.WriteLine($"Employee Name = {b1.Name} \nEmployee Amount = {b1.Amount}");

        // b1.Display("Utso Roy",500);

        BankEmployee b4 = new BankEmployee(500);
        Console.WriteLine(b4.value);

        TryCatch t = new TryCatch("utso");

        Array a = new Array();
        a.LearnToArray();


    }
}

