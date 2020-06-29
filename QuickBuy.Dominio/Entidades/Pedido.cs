using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.Entidades.ItemdeValor;
using System;
using System.Collections;

namespace QuickBuy.Dominio
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }
        public  DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }
        public string EnderecoCompleto { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormadePagamento FormaDePagamento { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Nao podem haver zero pedidos");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP deve estar preenchido");
        } 
    }
}
