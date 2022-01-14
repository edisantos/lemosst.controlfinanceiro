using lemosst.controlefinanceiro.Domain.Entidades.Contas;

namespace lemosst.controlefinanceiro.Domain.Entidades
{
    public class Estados
    {
        public int Id { get; set; }
        public string? NomeEstado { get; set; }
        public ICollection<Usuarios>? Usuarios { get; set; }
    }
}
