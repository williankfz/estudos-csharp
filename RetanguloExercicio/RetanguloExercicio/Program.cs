// See https://aka.ms/new-console-template for more information

//Fazer um programa para ler os valores da largura e altura de um retangulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe como mostrado na UML do vídeo.
//Calculo da área b * h
//Perimetro 2 * (a + h)
//Diagonal Math.sqrt(a * a + h * h)

using RetanguloExercicio;
using System.Globalization;

Retangulo r = new Retangulo();

Console.WriteLine("Entre a largura e altura do retangulo");
r.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
r.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("AREA = " + r.Area().ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("PERÍMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
