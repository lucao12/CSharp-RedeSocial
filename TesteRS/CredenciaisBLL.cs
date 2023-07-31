using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;

namespace TesteRS
{
    internal class CredenciaisBLL
    {
        public static void ValidaDados(Credenciais cadastro)
        {
            Erro.setErro(false);
            if (cadastro.getEmail().Equals(""))
            {
                Erro.setErro("O campo Email deve ser preenchido obrigatóriamente!");
                return;
            }
            else
            {
                if(!cadastro.getEmail().Contains("@"))
                {
                    Erro.setErro("O campo Email deve possuir obrigatóriamente @(domínio).com!");
                    return;
                }
            }
            if (cadastro.getNome().Equals(""))
            {
                Erro.setErro("O campo Nome deve ser preenchido obrigatóriamente!");
                return;
            }
            if (cadastro.getNascimento().Equals(""))
            {
                Erro.setErro("O campo Nascimento deve ser preenchido obrigatóriamente!");
                return;
            }
            else
            {
                DateTime dataNascimento = cadastro.getNascimento();
                DateTime hoje = DateTime.Now;

                int idade = hoje.Year - dataNascimento.Year;

                if (hoje < dataNascimento.AddYears(idade))
                {
                    idade--;
                }
                if (idade < 18)
                {
                    Erro.setErro("O usuário deverá ter mais de 18 anos!");
                    return;
                }
            }
            if (cadastro.getGenero().Equals(""))
            {
                Erro.setErro("O campo Genero deve ser preenchido obrigatóriamente!");
                return;
            }
            if (cadastro.getSenha().Equals(""))
            {
                Erro.setErro("O campo Senha deve ser preenchido obrigatóriamente com os requerimentos devidos!");
                return;
            }
            else
            {
                bool temNum = false, temLetMAI = false, temLetMIN = false, temSim = false, tem8ou20 = false;
                foreach (char c in cadastro.getSenha())
                {
                    if (Char.IsDigit(c))
                    {
                        temNum = true;
                    }
                    else
                    {
                        if (temNum == false)
                        {
                            temNum = false;
                        }
                    }
                    if (Char.IsLetter(c))
                    {
                        if (Char.IsUpper(c))
                        {
                            temLetMAI = true;
                        }
                        else
                        {
                            if (temLetMAI == false)
                            {
                                temLetMAI = false;
                            }
                        }
                        if (Char.IsLower(c))
                        {
                            temLetMIN = true;
                        }
                        else
                        {
                            if (temLetMIN == false)
                            {
                                temLetMIN = false;
                            }
                        }
                    }
                    if (Char.IsSymbol(c) || Char.IsPunctuation(c))
                    {
                        temSim = true;
                    }
                    else
                    {
                        if (temSim == false)
                        {
                            temSim = false;
                        }
                    }
                    if (cadastro.getSenha().Length >= 8 && cadastro.getSenha().Length <= 20)
                    {
                        tem8ou20 = true;
                    }
                    else
                    {
                        tem8ou20 = false;
                    }
                }
                if(temNum == false || temLetMIN == false || temLetMAI == false || temSim == false || tem8ou20 == false)
                {
                    Erro.setErro("O campo Senha deve ser preenchido com os requisitos!");
                    return;
                }
            }
            CadastroDAL.InsiraUmCadastro(cadastro);
            if (!Erro.getErro())
            {
                CadastroDAL.InsiraUmNome(cadastro);
            }
        }   
        public static void ValidaDadosLogin(Credenciais cadastro)
        {
            Erro.setErro(false);
            if (cadastro.getEmail().Equals(""))
            {
                Erro.setErro("O campo Email deve ser preenchido obrigatóriamente!");
                return;
            }
            else
            {
                if (!cadastro.getEmail().Contains("@"))
                {
                    Erro.setErro("O campo Email deve possuir obrigatóriamente @(domínio).com!");
                    return;
                }
            }
            if (cadastro.getSenha().Equals(""))
            {
                Erro.setErro("O campo Senha deve ser preenchido obrigatóriamente!");
                return;
            }
            CadastroDAL.Consulta(cadastro);
        }
        public static void Conecta()
        {
            CadastroDAL.Conecta();
        }
        public static void Desconecta()
        {
            CadastroDAL.Desconecta();
        }
        public static void ValidaCodigo(Credenciais cadastro)
        {
            Erro.setErro(false);
            if (cadastro.getCodigo().Equals(""))
            {
                Erro.setErro("O campo Codigo deve ser preenchido obrigatóriamente!");
                return;
            }
            CadastroDAL.verificaCodigo(cadastro);
        }
        public static void ValidaDadosEsqueci(Credenciais cadastro)
        {
            Erro.setErro(false);
            if (cadastro.getEmail().Equals(""))
            {
                Erro.setErro("O campo Email deve ser preenchido obrigatóriamente!");
                return;
            }
            else
            {
                if (!cadastro.getEmail().Contains("@"))
                {
                    Erro.setErro("O campo Email deve possuir obrigatóriamente @(domínio).com!");
                    return;
                }
            }
            CadastroDAL.ConsultaEsqueci(cadastro);
        }
        public static void ValidaSenha(Credenciais cadastro)
        {
            Erro.setErro(false);
            if (cadastro.getSenha().Equals(""))
            {
                Erro.setErro("O campo Senha deve ser preenchido obrigatóriamente com os requerimentos devidos!");
                return;
            }
            else
            {
                bool temNum = false, temLetMAI = false, temLetMIN = false, temSim = false, tem8ou20 = false;
                foreach (char c in cadastro.getSenha())
                {
                    if (Char.IsDigit(c))
                    {
                        temNum = true;
                    }
                    else
                    {
                        if (temNum == false)
                        {
                            temNum = false;
                        }
                    }
                    if (Char.IsLetter(c))
                    {
                        if (Char.IsUpper(c))
                        {
                            temLetMAI = true;
                        }
                        else
                        {
                            if (temLetMAI == false)
                            {
                                temLetMAI = false;
                            }
                        }
                        if (Char.IsLower(c))
                        {
                            temLetMIN = true;
                        }
                        else
                        {
                            if (temLetMIN == false)
                            {
                                temLetMIN = false;
                            }
                        }
                    }
                    if (Char.IsSymbol(c) || Char.IsPunctuation(c))
                    {
                        temSim = true;
                    }
                    else
                    {
                        if (temSim == false)
                        {
                            temSim = false;
                        }
                    }
                    if (cadastro.getSenha().Length >= 8 && cadastro.getSenha().Length <= 20)
                    {
                        tem8ou20 = true;
                    }
                    else
                    {
                        tem8ou20 = false;
                    }
                }
                if (temNum == false || temLetMIN == false || temLetMAI == false || temSim == false || tem8ou20 == false)
                {
                    Erro.setErro("O campo Senha deve ser preenchido com os requisitos!");
                    return;
                }
                CadastroDAL.AlteraEsqueci(cadastro);
            }
        }
        public static List<string> SelecionaTodosUsuarios(Credenciais cadastro)
        {
            List<string> manda = new List<string>();
            manda = CadastroDAL.SelecionaTodosUsuarios(cadastro);
            return manda;
        }
        public static List<string> SelecionaUsuarios(Credenciais cadastro)
        {
            List<string> manda = new List<string>();
            manda = CadastroDAL.SelecionaUsuarios(cadastro);
            return manda;
        }
        public static void Amizade(Credenciais cadastro)
        {
            CadastroDAL.Amizade(cadastro);
        }
        public static void VerificaAmizade(Credenciais cadastro)
        {
            CadastroDAL.VerificaAmizade(cadastro);
        }
        public static List<string> SeusAmigos(Credenciais cadastro)
        {
            List<string> manda = new List<string>();
            manda = CadastroDAL.SeusAmigos(cadastro);
            return manda;
        }
        public static void VerificaPost(Credenciais cadastro)
        {
            Erro.setErro(false);
            if (cadastro.getPost().Equals("") || cadastro.getPost().Equals("No que está pensando?"))
            {
                Erro.setErro("Post vazio? reconsidere!");
                return;
            }
        }
        public static List<Label> EscreveOsPost(Credenciais cadastro)
        {
            List<Label> posts = new List<Label>();
            posts = CadastroDAL.EscreveOsPost(cadastro);
            return posts;
        }
        public static List<Image> EscreveAsImagens(Credenciais cadastro)
        {
            List<Image> posts = new List<Image>();
            posts = CadastroDAL.EscreveAsImagens(cadastro);
            return posts;
        }
        public static void FotoPerfilAmigo(Credenciais cadastro)
        {
            CadastroDAL.FotoPerfilAmigo(cadastro);
        }
        public static void InsiraUmPost(Credenciais cadastro)
        {
            CadastroDAL.InsiraUmPost(cadastro);
        }
        public static Image FotoPost(string cadastro)
        {
            Image posts = CadastroDAL.FotoPost(cadastro);
            return posts;   
        }
        public static void insiraFoto(Credenciais cadastro)
        {
            CadastroDAL.insiraFoto(cadastro);
        }
        public static Image ImagemPerfil(Credenciais cadastro)
        {
            Image posts = CadastroDAL.ImagemPerfil(cadastro);
            return posts;
        }
        public static void insiraCadastros(Credenciais cadastro)
        {
            CadastroDAL.insiraCadastros(cadastro);

        }
        public static List<Label> EscreveOsPostPerfil(Credenciais cadastro)
        {
            List<Label> posts = new List<Label>();
            posts = CadastroDAL.EscreveOsPostPerfil(cadastro);
            return posts;
        }
        public static List<Image> EscreveAsImagensPerfil(Credenciais cadastro)
        {
            List<Image> posts = new List<Image>();
            posts = CadastroDAL.EscreveAsImagensPerfil(cadastro);
            return posts;
        }
        public static void UpdatePerfil(Credenciais cadastro)
        {
            CadastroDAL.UpdatePerfil(cadastro);
        }
        public static void setaDados(Credenciais cadastro)
        {
            CadastroDAL.setaDados(cadastro);
        }
        public static void updateFoto(Credenciais cadastro)
        {
            CadastroDAL.updateFoto(cadastro);
        }
    }
}

