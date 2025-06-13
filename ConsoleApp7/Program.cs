int firstNumber;
int secondNumber;

Console.WriteLine("Enter first number: ");
firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
secondNumber = int.Parse(Console.ReadLine());

try
{
    if (secondNumber == 0)
    {
        Console.WriteLine("You can't divide by 0!");
    }
     
    else
    {
        int result = firstNumber / secondNumber;  
        Console.WriteLine($"Result: {result}");  
    }
}
    catch
{
    Console.WriteLine("Error or exception");
}
finally
{
    Console.WriteLine("The division operation is complete.");
}
