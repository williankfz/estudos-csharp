// See https://aka.ms/new-console-template for more information

using Calculadora;

Valores num1, num2, operador;
num1 = new Valores();
num2 = new Valores();
operador = new Valores();

Console.WriteLine("Digite o primeiro valor: ");

num1.valor = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");

num2.valor = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha o operador: ");

operador.operador = Console.ReadLine();

switch (operador.operador)
{
    case "+":
        Console.WriteLine(num1.valor + num2.valor);
        break;
    case "-":
        Console.WriteLine(num1.valor - num2.valor);
        break;
    case "*":
        Console.WriteLine(num1.valor * num2.valor);
        break;
    case "/":
        Console.WriteLine(num1.valor / num2.valor);
        break;
    default:
        Console.WriteLine("Valor não identificado");
        break;
}