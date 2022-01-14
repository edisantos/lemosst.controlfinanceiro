using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemosst.controlefinanceiro.Domain.Entidades.Contas
{
    public class Usuarios:IdentityUser<int>
    {
        public string? FullName { get; set; }
        public string? Endereco { get; set; }
        public int BairroId { get; set; }
        public int CidadeId { get; set; }
        public int EstadoId { get; set; }
    }
}
