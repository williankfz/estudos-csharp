// See https://aka.ms/new-console-template for more information

//Fazer um programa para ler o nome de um aluno e as tres notas que ele obteve nos tres trimestres do ano (Primeiro vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer também se o aluno está aprovado ou reprovado e, em caso negativo, quantos pontos faltam para o aluno obter o minimo para ser aprovado (que é 60 pontos). Voce deve criar uma classe Aluno para resolve o problema
using AlunoNotaExercicio;
using System.Globalization;

Aluno aluno = new Aluno();
 
Console.Write("Nome do aluno: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite as tres notas do aluno: ");
aluno.N1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
aluno.N2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Nota final: " + aluno.TotalNota().ToString("F2",CultureInfo.InvariantCulture));

if (aluno.Aprovado()) {
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
    Console.WriteLine("Faltaram " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + "Pontos");
}