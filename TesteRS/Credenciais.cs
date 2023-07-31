using System;
using System.Collections.Generic;

namespace TesteRS
{
    public class Credenciais
    {
        private string nome;
        private string nomeAmigo;
        private string email;
        private string emailAmigo;
        private string genero;
        private string generoAmigo;
        private DateTime nascimento;
        private string apelido;
        private string apelidoAmigo;
        private string senha;
        private string codigo;
        private string fotoPerfil;
        private string post;
        private string amigo;
        private string foto;
        private List<string> amigos = new List<string>();
        private List<string> amigos1 = new List<string>();

        public void setFotoPerfil(string FotoPerfil) { fotoPerfil = FotoPerfil; }
        public string getFotoPerfil() { return fotoPerfil; }
        public void setEmailAmigo(string EmailAmigo) { emailAmigo = EmailAmigo; }
        public void setApelidoAmigo(string ApelidoAmigo) { apelidoAmigo = ApelidoAmigo; }
        public void setNomeAmigo(string NomeAmigo) { nomeAmigo = NomeAmigo; }
        public void setGeneroAmigo(string GeneroAmigo) { generoAmigo = GeneroAmigo; }
        public string getApelidoAmigo() { return apelidoAmigo; }
        public string getNomeAmigo() { return nomeAmigo; }
        public string getGeneroAmigo() { return generoAmigo; }

        public void ClearAmigos() { amigos.Clear(); }
        public void ClearAmigos1() { amigos1.Clear(); }
        public string getEmailAmigo() { return emailAmigo; }
        public void setAmigos(string Amigos) { amigos.Add(Amigos); }
        public List<string> getAmigos() { return amigos; }
        public void setAmigos1(string Amigos1) { amigos1.Add(Amigos1); }
        public List<string> getAmigos1() { return amigos1; }
        public void setFoto(string Foto) { foto = Foto; }
        public string getFoto() { return foto; }

        public void setAmigo(string Amigo) { amigo = Amigo; }
        public string getAmigo() { return amigo; }

        public void setPost(string Post) { post = Post; }
        public string getPost() { return post; }

        public void setNome(string Nome) { nome = Nome; }
        public string getNome() { return nome; }
        public void setEmail(string Email) { email = Email; }
        public string getEmail() { return email; }
        public void setGenero(string Genero) { genero = Genero; }
        public string getGenero() { return genero; }
        public void setNascimento(DateTime Nascimento) { nascimento = Nascimento; }
        public DateTime getNascimento() { return nascimento; }
        public void setApelido(string Apelido) { apelido = Apelido; }
        public string getApelido() { return apelido; }
        public void setSenha(string Senha) { senha = Senha; }
        public string getSenha() { return senha; }
        public void setCodigo(string Codigo) { codigo = Codigo; }
        public string getCodigo() { return codigo; }
    }
}
