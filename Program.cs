namespace threeNumbers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, por gentileza, digite três números!");
        double number1 = Convert.ToDouble(Console.ReadLine());
        double number2 = Convert.ToDouble(Console.ReadLine());
        double number3 = Convert.ToDouble(Console.ReadLine());

        if(number3 > number2 && number2 > number1) Console.WriteLine($"{number1}, {number2}, {number3}");
        if(number3 > number2 && number2 > number1) Console.WriteLine($"{number1}, {number2}, {number3}");
        if(number3 > number2 && number1 > number2) Console.WriteLine($"{number2}, {number1}, {number3}");
        if(number2 > number3 && number3 > number1) Console.WriteLine($"{number1}, {number3}, {number2}");
        if(number2 > number3 && number1 > number3) Console.WriteLine($"{number3}, {number1}, {number2}");
        if(number1 > number2 && number2 > number3) Console.WriteLine($"{number3}, {number2}, {number1}");
        if(number1 > number2 && number3 > number2) Console.WriteLine($"{number2}, {number3}, {number1}");       
        
    }
}


