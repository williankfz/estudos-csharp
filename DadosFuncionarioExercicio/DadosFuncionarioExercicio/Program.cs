// See https://aka.ms/new-console-template for more information

//Fazer um programa para ler os dados de um funcionario (nome, salário bruto e impostos). Em seguida mostrar os dados do funcionario (nome e salario liquido). Em seguida, aumentar o salario do funcionario com base em uma porcentagem dada (somente o salario bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionario.
//Conta de porcentagem: SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
using DadosFuncionarioExercicio;
using System.Globalization;

Funcionario func = new Funcionario();

Console.Write("Nome: ");
func.Nome = Console.ReadLine();

Console.Write("Salario bruto: ");
func.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.Write("Imposto: ");
func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Funcionário: " + func);

Console.Write("Digite a porcentagem para aumentar o salário: ");
double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
func.AumentarSalario(porcentagem);

Console.WriteLine("Dados atualizados: " + func);

