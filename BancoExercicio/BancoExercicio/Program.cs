﻿// See https://aka.ms/new-console-template for more information

using BancoExercicio;
using System.Globalization;

ContaBancaria conta;

Console.Write("Entre o número da conta: ");
int numero = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
char resp = char.Parse(Console.ReadLine());

if (resp == 's' || resp == 'S') {
    Console.Write("Entre o valor de depósito inicial: ");
    double saldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero,titular,saldo);
}
else
{
    conta = new ContaBancaria(numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da conta:");
Console.WriteLine(conta);

Console.WriteLine();

Console.Write("Entre um valor para depósito: ");
double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
conta.Deposito(quantia);

Console.WriteLine();
Console.WriteLine("Dados da conta atualizado:");
Console.WriteLine(conta);

Console.Write("Entre um valor para saque: ");
quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
conta.Saque(quantia);

Console.WriteLine();
Console.WriteLine("Dados da conta atualizado:");
Console.WriteLine(conta);