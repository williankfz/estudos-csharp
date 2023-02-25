// See https://aka.ms/new-console-template for more information

using MediaEscolar;

Notas nota1, nota2,nota3, media;
nota1 = new Notas();
nota2 = new Notas();
nota3 = new Notas();
media = new Notas();

Console.WriteLine("Digite a primeira nota: ");
nota1.nota = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
nota2.nota = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
nota3.nota = int.Parse(Console.ReadLine());

media.media = (nota1.nota + nota2.nota + nota3.nota) / 3;
int resultadoFinal = media.media;

if (resultadoFinal >= 6)
{
    Console.WriteLine("Sua média é: " + resultadoFinal + " Você passou.");
}else if(resultadoFinal >= 4 && resultadoFinal < 6)
{
    Console.WriteLine("Sua média é: " + resultadoFinal + " Você está de recuperação.");
}
else
{
    Console.WriteLine("Sua média é: " + resultadoFinal + " Você está reprovado.");
}


