﻿using lemosst.controlefinanceiro.Domain.Entidades.Contas;

namespace lemosst.controlefinanceiro.Domain.Entidades
{
    public class Bairros
    {
        public int Id { get; set; }
        public string?NomeBarro  { get; set; }

        public ICollection<Usuarios>? Usuarios { get; set; }
    }
}
