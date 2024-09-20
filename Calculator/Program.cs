namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");

            Console.WriteLine("Enter Number 1");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator from the list - (+, -, *, /)");


            switch (Console.ReadLine())
            {
                case "+": 
                    Console.WriteLine("Addition");
                    double addition = number1 + number2;
                    Console.WriteLine("{0} + {1} = {2}",number1,number2,addition);
                    break;
                case "-":
                    Console.WriteLine("Substraction");
                    double substraction = number1 - number2;
                    Console.WriteLine("{0} - {1} = {2}", number1, number2, substraction);
                    break;
                case "*":
                    Console.WriteLine("Multiplication");
                    double multiplication = number1 * number2;
                    Console.WriteLine("{0} * {1} = {2}", number1, number2, multiplication);
                    break;
                case "/":
                    Console.WriteLine("Division");
                    if (number2 == 0) 
                    {
                        Console.WriteLine("Number Cannot be divided with 0");
                    }
                    else
                    {
                        double division = number1 / number2;
                        Console.WriteLine("{0} / {1} = {2}", number1, number2, division);
                    }
                    
                    break;
                default: Console.WriteLine("Wrong Operator");
                    break;
            } 
                
        }
    }
}
