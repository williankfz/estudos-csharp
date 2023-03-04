// See https://aka.ms/new-console-template for more information
using EstoqueProdutoExercicio;
using System.Globalization;

Produto produto;

Console.WriteLine("Entre com os dados do produto: ");

Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.Write("Quantidade: ");
int quantidade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

produto = new Produto(nome, preco, quantidade);

Console.WriteLine(produto);
Console.WriteLine();

Console.Write("Aumente o numero do produto no estoque: ");
int novoValor = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
produto.Adicionar(novoValor);

Console.WriteLine("Valor atualizado: ");
Console.WriteLine(produto);

Console.WriteLine();

Console.Write("Diminua o numero do produto no estoque: ");
novoValor = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
produto.Remover(novoValor);

Console.WriteLine("Valor atualizado: ");
Console.WriteLine(produto);
