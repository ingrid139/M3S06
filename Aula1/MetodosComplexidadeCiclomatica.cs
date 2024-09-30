using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula1.Metodo;

namespace Aula1
{
    public class MetodosComplexidadeCiclomatica
    {
        //Antes
        public decimal CalcularPreco(Produto produto)
        {
            if (produto.Tipo == "A")
            {
                if (produto.Quantidade > 10)
                {
                    return produto.Preco * 0.9m;
                }
                else
                {
                    return produto.Preco;
                }
            }
            else if (produto.Tipo == "B")
            {
                if (produto.Quantidade > 5)
                {
                    return produto.Preco * 0.8m;
                }
                else
                {
                    return produto.Preco * 0.9m;
                }
            }
            return produto.Preco;
        }

        //Depois
        public decimal CalcularPreco_(Produto produto)
        {
            decimal preco = produto.Preco;
            preco = AplicarDescontoPorTipo(produto, preco);
            return preco;
        }

        private decimal AplicarDescontoPorTipo(Produto produto, decimal preco)
        {
            switch (produto.Tipo)
            {
                case "A":
                    return produto.Quantidade > 10 ? preco * 0.9m : preco;
                case "B":
                    return produto.Quantidade > 5 ? preco * 0.8m : preco * 0.9m;
                default:
                    return preco;
            }
        }
    }
}
