using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleState
{
    public interface State
    {

        public void solicitarListaProdutos();
        public void confirmarProduto(string dadosProduto);
        public void confirmarPagamento(string dadosPagamento);
        public void cancelarTransacao();

    }
}
