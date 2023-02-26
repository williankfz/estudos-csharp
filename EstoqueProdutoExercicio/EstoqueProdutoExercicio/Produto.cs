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
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double Total()
        {
            return Preco * Quantidade;
        }

        public void Adicionar(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void Remover(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" + Total().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
