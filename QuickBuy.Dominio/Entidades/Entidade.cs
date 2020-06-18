using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao 
        {

            get { return _mensagenValidacao ?? (_mensagemValidacao = new List<string>()); }

        }
        protected void LimparMensagemValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

         public abstract void Validate();
        
        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
