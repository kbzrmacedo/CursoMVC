﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMVC.Domain.Entity
{
    public class Cliente
    {
        public Cliente()
        {
            ClienteId = Guid.NewGuid();
        }

        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; } //virtual = pode ser sobrescrita e habilita o layzload
        
    }
}
