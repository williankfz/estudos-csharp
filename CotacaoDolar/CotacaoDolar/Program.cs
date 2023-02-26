// See https://aka.ms/new-console-template for more information
using CotacaoDolar;
using System.Globalization;


Console.Write("Qual é a cotação do dolar? ");
double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.Write("Quantos dolares você vai comprar? ");
double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double result = ConversorDeMoeda.Calculo(cotacao, quantia);

Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2",CultureInfo.InvariantCulture));