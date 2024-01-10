 
string input1 = Console.ReadLine();
string input2 = Console.ReadLine();
try
{
    int number1 = Convert.ToInt32(input1);
    int number2 = Convert.ToInt32(input2);

    if (number2 == 0)
    {
        Console.WriteLine("You can not divide to 0.");
    }
    else
    {
        int result = number1 / number2;
        Console.WriteLine($"Result: {result}");
    }
}
catch
{
    Console.WriteLine("Uncorrect input");
}