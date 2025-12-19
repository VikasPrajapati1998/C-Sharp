class Example
{
    private int secretNumber = 42; // Private: Only accessible withing this class

    public void Display()
    {
        Console.WriteLine("Access Modifier Example: " + secretNumber);
    }
}


class Program
{
    static void Main()
    {
        Example obj = new Example();
        obj.Display();
    }
}
