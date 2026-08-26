
class Bank
{
    private string name;
    private int amount;

// short
//    public string Name { get; set; }
//     public int Amount { get; set; }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Amount
    {
        get{ return amount; }
        set {
            amount = value; 
        Console.WriteLine(
            value >= 500 ? "Good Amount" : "Amount is low"
        ); }
  
    }


    public void Display(string name, int amount)
    {
        Console.WriteLine($"Employee Name = {name}\n Employee Total Amount = {amount}");
    }


}