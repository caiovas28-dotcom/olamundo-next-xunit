using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroTeste.App
{
    public class HelloWorldService
    {
        public string GerarSaudacao_DeveRetornarSucesso(string? nome)
        {
            if (string.IsNullOrEmpty(nome)){
                return "Olá, Mundo!";
            }
            else
            {
                return $"ola, {nome}";
            }
        }
    }
}