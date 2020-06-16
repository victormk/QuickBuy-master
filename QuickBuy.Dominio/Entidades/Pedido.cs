﻿using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.Entidades.ItemdeValor;
using System;
using System.Collections;

namespace QuickBuy.Dominio
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }
        public  DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }
        public string EnderecoCompleto { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormadePagamento FormaDePagamento { get; set; }
    }
}
