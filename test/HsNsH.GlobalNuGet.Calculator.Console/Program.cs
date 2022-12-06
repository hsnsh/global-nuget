namespace HsNsH.GlobalNuGet.Calculator.Console;

public static class Program
{
    public static void Main(string[] args)
    {
        ICalculator calc = new Calculator();

        System.Console.WriteLine($" 2 + 3 = {calc.Add(2, 3)}");
    }
}