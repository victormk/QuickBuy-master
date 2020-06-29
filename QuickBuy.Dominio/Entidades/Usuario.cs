using System.Collections;

namespace QuickBuy.Dominio.Entidades
{
   public class Usuario : Entidade
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        //usuário tem um ou mais pedidos
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate ()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não informado");
            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("SenhaNaoInformada");
        }
    }
}
