// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o primeiro valor: ");

double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");

double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha o operador: ");

string operador = Console.ReadLine();

switch (operador)
{
    case "+":
        Console.WriteLine(num1 + num2);
        break;
    case "-":
        Console.WriteLine(num1 - num2);
        break;
    case "*":
        Console.WriteLine(num1 * num2);
        break;
    case "/":
        Console.WriteLine(num1 / num2);
        break;
    default:
        Console.WriteLine("Valor não identificado");
        break;
}