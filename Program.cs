using System;
class Test
{
    public static void Main(string[] args)
    {
        //Variable Declaration
        // string name = "Utso";
        // Console.WriteLine(name);
        // char firstLetter = name[0];
        // Console.WriteLine(firstLetter);
        // double number = 3.14;
        // Console.WriteLine(number);
        // int age = 25;
        // Console.WriteLine(age);
        // int a = b = c = 10;  multiple variable declaration 
        // const string varcityName = "Uttara University"; Constant variable
        // string varcityName = "Uttara University";
        // Console.WriteLine(varcityName);
        // varcityName = "Dhaka University";
        // Console.WriteLine(varcityName);

        // Lean to get user input 
        // Console.WriteLine("Write Your Name");
        // string StudentName = Console.ReadLine();
        // Console.WriteLine("My Name Is " + StudentName);

        // int a = 10;
        // int b = 3;

        // double result = (double)a / b;
        // Console.WriteLine(result.ToString("F3"));



        // int number1;
        // int number2;

        // Console.WriteLine("Please Write First Number");
        // number1 = int.Parse(Console.ReadLine());
        // Console.WriteLine("Please Write Second Number");
        // number2 = int.Parse(Console.ReadLine());
        // int sum = number1 + number2;
        // Console.WriteLine("Total Sum " + sum);
        // Console.WriteLine("Type" + sum.GetType());

        // int age;

        // Console.WriteLine("Enter Your Age");
        // age = int.Parse(Console.ReadLine());

        // for (int i = 0;  i <= age; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // if (age <= 12)
        // {
        //     Console.WriteLine("Child");
        // }
        // else if (age <= 17)
        // {
        //     Console.WriteLine("Teenager");
        // }
        // else
        // {
        //     Console.WriteLine("Adult");
        // }

        // string text;
        // Console.WriteLine("Please Write your Name");
        // text = Console.ReadLine();

        // int count = 0;

        // for (int i = 0; i < text.Length; i++)
        // {
        //     if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' ||
        //         text[i] == 'o' || text[i] == 'u')
        //     {
        //         count++;
        //     }
        // }

        // Console.WriteLine($"Vowel count: {count}");

        //  switch short 

        // int digit = 7;
        // string message = digit switch
        // {
        //     1 => "One",
        //     2 => "Two",
        //     3 => "Three",
        //     4 => "Four",
        //     5 => "Five",
        //    _  => "Unknown"


        // };
        // Console.WriteLine($"Value : {message}");

        SwitchExample.Run();

        int result = MathHelper.Sum(20, 30);
        Console.WriteLine(result);
    }
}


