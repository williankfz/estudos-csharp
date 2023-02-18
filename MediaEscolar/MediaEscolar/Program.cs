// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite a primeira nota: ");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
int nota3 = int.Parse(Console.ReadLine());

int media = (nota1 + nota2 + nota3) / 3;

if (media >= 6)
{
    Console.WriteLine("Sua média é: " + media + " Você passou.");
}else if(media >=4 && media < 6)
{
    Console.WriteLine("Sua média é: " + media + " Você está de recuperação.");
}
else
{
    Console.WriteLine("Sua média é: " + media + " Você está reprovado.");
}


