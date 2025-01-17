﻿using System;
using OO_HERANCAS_INTERFACES.Sistemas;

namespace OO_HERANCAS_INTERFACES.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        { }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
