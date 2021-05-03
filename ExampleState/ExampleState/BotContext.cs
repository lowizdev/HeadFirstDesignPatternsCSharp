using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleState
{
    public class BotContext
    {

        private State _state = null;

        public BotContext()
        {
            this._state = new BotAguardandoState(this);
        }

        public void changeState(State state) {

            this._state = state;

        }

        public void solicitarListaProdutos() {
            this._state.solicitarListaProdutos();
        }

        public void confirmarProduto() {
            this._state.confirmarProduto("Algum produto, passado aqui pra simplificar");
        }
        public void confirmarPagamento() {
            this._state.confirmarPagamento("Pagamento, passado aqui pra simplificar");
        }
        public void cancelarTransacao() {
            this._state.cancelarTransacao();
        }

        public void aplicarDesconto() {

            this._state.cancelarTransacao();

            Console.WriteLine("Exibindo Lista com desconto aplicado!");

            this._state.solicitarListaProdutos();

        }

        public void fecharBot() {

            Console.WriteLine("Finalizando...");

        }



    }
}
