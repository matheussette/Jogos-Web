using System;
using System.Collections.Generic;
using System.Text;

namespace VetoresHotel
{
    class Aluguel
    {
        public string nome { get; set; } //encapsulamento
        public string email { get; set; }// encapsulamento
        public Aluguel(string nome, string email)
        {
            this.nome = nome; //  acessar um membro da instância da própria classe
            this.email = email;// acessar o membro da instância da própria classe
        }
        public override string ToString()
        {
            return nome + ", " + email; //retorna a função main
        }
    }
}
            
