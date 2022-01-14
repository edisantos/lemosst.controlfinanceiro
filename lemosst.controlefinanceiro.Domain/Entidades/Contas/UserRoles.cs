using Microsoft.AspNetCore.Identity;

namespace lemosst.controlefinanceiro.Domain.Entidades.Contas
{
    public class UserRoles:IdentityUserRole<int>
    {
        public Usuarios? Usuarios { get; set; }
        public Roles? Roles { get; set; }
    }
}
