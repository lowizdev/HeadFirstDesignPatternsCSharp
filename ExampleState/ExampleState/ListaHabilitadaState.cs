using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleState
{
    public class ListaHabilitadaState : State
    {
        private BotContext _context = null; 
        public ListaHabilitadaState(BotContext context)
        {
            this._context = context;
        }
        public void cancelarTransacao()
        {
            Console.WriteLine("Não há transação no momento");
        }

        public void confirmarPagamento(string dadosPagamento)
        {
            Console.WriteLine("Selecione o produto a pagar!");
        }

        public void confirmarProduto(string dadosProduto)
        {
            Console.WriteLine("Selecionado o produto " + dadosProduto); //For simplicity

            this._context.changeState(new TransacaoExecutandoState(this._context));

        }

        public void solicitarListaProdutos()
        {
            Console.WriteLine("Atualizando a lista de produtos...");
            Console.WriteLine("Exibindo lista e afins...");
        }
    }
}
