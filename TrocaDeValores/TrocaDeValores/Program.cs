// See https://aka.ms/new-console-template for more information
//Receber valores em duas variaveis e fazer com que os valores troquem entre si

Console.WriteLine("Primeiro valor: ");
float valor1 = float.Parse(Console.ReadLine());

Console.WriteLine("Segundo valor: ");
float valor2 = float.Parse(Console.ReadLine());

valor1 = valor1 + valor2;
valor2 = valor1 - valor2;
valor1 = valor1 - valor2;

Console.WriteLine("Primeiro valor: " + valor1);
Console.WriteLine("Segundo valor: " + valor2);

