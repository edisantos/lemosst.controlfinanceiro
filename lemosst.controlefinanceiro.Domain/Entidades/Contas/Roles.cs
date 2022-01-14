﻿using Microsoft.AspNetCore.Identity;

namespace lemosst.controlefinanceiro.Domain.Entidades.Contas
{
    public class Roles:IdentityRole<int>
    {
        public ICollection<UserRoles>? UserRols { get; set; }
    }
}
