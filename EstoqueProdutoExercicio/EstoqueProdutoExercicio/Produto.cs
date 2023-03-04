using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EstoqueProdutoExercicio
{
    internal class Produto
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double valor, int quantiadade) {
            Nome = nome;
            Valor = valor;
            Quantidade = quantiadade;
        }

        public double Total()
        {
            return Valor * Quantidade;
        }

        public void Adicionar(int quantidade)
        {
            Quantidade += quantidade;
            
        }

        public void Remover(int quantidade)
        {
            Quantidade-= quantidade;
            
        }

        public override string ToString()
        {
            return "O valor final do estoque é: Nome: " + Nome + ",Valor: $" + Valor + ", Quantidade: " + Quantidade + ", Total: $" + Total().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
