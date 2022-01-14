using lemosst.controlefinanceiro.Domain.Entidades.Contas;

namespace lemosst.controlefinanceiro.Domain.Entidades
{
    public class Cidades
    {
        public int Id { get; set; }
        public string? NomeCidade { get; set; }

        public ICollection<Usuarios>? Usuarios { get; set; }
    }
}
