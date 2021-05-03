using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleState
{
    class BotAguardandoState:State
    {

        private BotContext _context = null;

        public BotAguardandoState(BotContext context)
        {
            this._context = context;
        }

        public void cancelarTransacao()
        {
            Console.WriteLine("Nao ha transacao a cancelar");
        }

        public void confirmarPagamento(string dadosPagamento)
        {
            Console.WriteLine("Nao ha pagamento a confirmar");
        }

        public void confirmarProduto(string dadosProduto)
        {
            Console.WriteLine("Nao ha produto a escolher");
        }

        public void solicitarListaProdutos()
        {
            Console.WriteLine("Exibindo lista e afins...");
            this._context.changeState(new ListaHabilitadaState(this._context));
        }
    }
}
