using System;

namespace ExampleState
{
    class Program
    {
        static void Main(string[] args)
        {
            BotContext b1 = new BotContext();

            Console.WriteLine("-> Teste de fluxo normal");
            b1.solicitarListaProdutos();
            b1.cancelarTransacao();
            b1.confirmarProduto();
            b1.confirmarPagamento();
            b1.solicitarListaProdutos();
            b1.confirmarProduto();
            b1.cancelarTransacao();
            //b1.fecharBot();

            Console.WriteLine("-> Teste da compra com desconto");
            b1.solicitarListaProdutos();
            b1.confirmarProduto();
            b1.aplicarDesconto();
            b1.confirmarProduto();
            b1.confirmarPagamento();

            b1.fecharBot();
        }
    }
}
