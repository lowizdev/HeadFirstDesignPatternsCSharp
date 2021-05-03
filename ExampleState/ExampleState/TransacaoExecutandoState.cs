using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleState
{
    public class TransacaoExecutandoState : State
    {

        private BotContext _context = null;

        public TransacaoExecutandoState(BotContext context)
        {
            this._context = context;
        }
        
        public void cancelarTransacao()
        {
            Console.WriteLine("Transacao Cancelada");
            this._context.changeState(new BotAguardandoState(this._context));
        }

        public void confirmarPagamento(string dadosPagamento)
        {
            Console.WriteLine("Pagamento Confirmado!");
            this._context.changeState(new BotAguardandoState(this._context));
        }

        public void confirmarProduto(string dadosProduto)
        {
            Console.WriteLine("Produto já selecionado");
        }

        public void solicitarListaProdutos()
        {
            Console.WriteLine("Finalize o pagamento para exibir novamente a lista");
        }
    }
}
