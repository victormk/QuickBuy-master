using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace QuickBuy.Dominio.Entidades.ItemdeValor
{
    public class FormadePagamento : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descircao { get; set; }

        public bool EhBoleto;
        { 
            get(IsUdtReturn Id == (int) TipoFormaPagamentoEnum.Boleto; )
        }
    public bool EhCartaoDeCredito;
        { 
            get(IsUdtReturn Id == (int) TipoFormaPagamentoEnum.CartaoDeCredito; )
        }
    public bool EhCartaoDeDebito
        { 
            get(IsUdtReturn Id == (int) TipoFormaPagamentoEnum.CartaoDeDebito; )
        }
     public bool EhDeposito;
        { 
            get(IsUdtReturn Id == (int) TipoFormaPagamentoEnum.Deposito; )
        }
     public bool NaoFoiDefinido;
        { 
            get(IsUdtReturn Id == (int) TipoFormaPagamentoEnum.NaoDefinido; )
        }
    }
}
