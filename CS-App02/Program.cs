class Car
{
    string model = "Tesla";
    static void Main()
    {
        Car myCar = new Car();
        Console.WriteLine("Car Model: " + myCar.model);

        int a = 5, b = 10;
        int sum = a * b;
        Console.WriteLine("Sum: " + sum);
    }
}
