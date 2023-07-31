using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteRS.bin
{
    internal class Credenciais
    {
        private string nome;
        private string senha;
        private string email;
        private string nascimento;
        private string apelido;
        private string genero;

        public void setNome(string Nome) { nome = Nome; } 
        public void setSenha(string Senha) { senha = Senha; }
        public void setEmail(string Email) { email = Email; }
        public void setNascimento(string Nascimento) { nascimento = Nascimento; }
        public void setApelido(string Apelido) { apelido = Apelido; }
        public void setGenero(string Genero) { genero = Genero; }

        public string getNome() { return nome; }
        public string getSenha() { return senha; }
        public string getEmail() { return email; }
        public string getNascimento() { return nascimento; }
        public string getApelido() { return apelido; }
        public string getGenero() { return genero; }
    }
}
