int firstNumber;
int secondNumber;

Console.WriteLine("Enter first number: ");
while (!int.TryParse(Console.ReadLine(), out firstNumber)) // Added a check to ensure that the user enters only numbers
{
    Console.WriteLine("Enter only integers: ");
}

Console.WriteLine("Enter second number: ");
while (!int.TryParse(Console.ReadLine(), out secondNumber))
{
    Console.WriteLine("Enter only integers: ");
}

try
{
    if (secondNumber == 0)
    {
        Console.WriteLine("You can't divide by 0!");
    }
     
    else
    {
        double result = (double)firstNumber / secondNumber; // Converted the dividend to a double
        Console.WriteLine($"Result: {result:F3}"); // Displayed the result and showed 3 digits after the dot
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
