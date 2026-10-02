using System;

namespace CalculadoraDescontos.App
{
    public class DescontoService
    {
        // 1. Retorna a categoria do cliente baseado no total de compras
        public string ObterCategoriaCliente(int totalCompras)
        {
            if (totalCompras < 5) return "BRONZE";
            if (totalCompras <= 10) return "PRATA";
            return "OURO";
        }

        // 2. Retorna o valor final com o desconto aplicado
        public int CalcularDescontoPorPercentual(int valorOriginal, int percentualDesconto)
        {
            return valorOriginal - (valorOriginal * percentualDesconto / 100);
        }

        // 3. Retorna true se o cliente tiver 18 anos ou mais OU se for a primeira compra
        public bool EValidoParaCupom(int idade, bool primeiraCompra)
        {
            return idade >= 18 || primeiraCompra;
        }
    }
}