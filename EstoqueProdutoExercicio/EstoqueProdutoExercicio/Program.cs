// See https://aka.ms/new-console-template for more information
using EstoqueProdutoExercicio;
using System.Globalization;

Produto p = new Produto();

Console.WriteLine("Entre com os dados do produto: ");

Console.Write("Nome: ");
p.Nome = Console.ReadLine();

Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade: ");
p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine(p);

Console.WriteLine();

Console.Write("Aumente o numero de produtos no estoque: ");
int qte = int.Parse(Console.ReadLine());
p.Adicionar(qte);

Console.WriteLine(p);

Console.WriteLine();

Console.Write("Diminua o numero de produtos no estoque: ");
qte = int.Parse(Console.ReadLine());
p.Remover(qte);

Console.WriteLine("O valor final do estoque é: " + p);
