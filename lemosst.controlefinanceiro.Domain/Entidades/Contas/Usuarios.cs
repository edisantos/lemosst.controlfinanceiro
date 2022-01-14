using Microsoft.AspNetCore.Identity;

namespace lemosst.controlefinanceiro.Domain.Entidades.Contas
{
    public class Usuarios:IdentityUser<int>
    {
        public string? FullName { get; set; }
        public string? Endereco { get; set; }
        public int BairroId { get; set; }
        public int CidadeId { get; set; }
        public int EstadoId { get; set; }
        public Bairros? Bairros { get; set; }
        public Cidades? Cidades { get; set; }
        public Estados? Estados { get; set; }

        public ICollection<UserRoles>? UserRoles { get; set; }
    }
}
