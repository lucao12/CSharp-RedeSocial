using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using System.Data.OleDb;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Configuration;

namespace TesteRS
{
    internal class CadastroDAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDRSTeste1.mdb";
        private static OleDbConnection conexao = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader resultado;

        public static void Conecta()
        {
            try
            {
                conexao.Open();
            }
            catch (Exception)
            {
                Erro.setErro("Problemas ao se conectar com o Banco de dados");
            }
        }

        public static void Desconecta()
        {
            conexao.Close();
        }

        public static void Consulta(Credenciais cadastro)
        {
            String aux = "select * from TabCadastro where cd_Email = @email";
            strSQL = new OleDbCommand(aux, conexao);

            strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = cadastro.getEmail();

            resultado = strSQL.ExecuteReader();

            string password = cadastro.getSenha();
            password = HashPassword(password);

            Erro.setErro(false);
            if (resultado.Read())
            {
                string email = resultado.GetString(0), senha = resultado.GetString(1);
                if (cadastro.getEmail() != email || password != senha)
                {
                    Erro.setErro("Email e/ou senha estão incorretas!");
                }
            }
            else
            {
                Erro.setErro("Email não cadastrado!");
            }
        }
        public static void InsiraUmCadastro(Credenciais cadastro)
        {
            Random random = new Random();
            string codigo = random.Next(100000, 999999).ToString();

            String aux = "insert into TabCadastro(cd_Email,cd_Senha,dt_Nascimento,ds_Genero,nm_Usuário,nm_Apelido, cd_Verifica, ds_Caminho) values (@email,@senha,@nascimento,@genero,@usuario,@apelido,@verifica,@caminho)";
            strSQL = new OleDbCommand(aux, conexao);

            string password = cadastro.getSenha();
            password = HashPassword(password);

            Erro.setErro(false);
            try
            {
                strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = cadastro.getEmail();
                strSQL.Parameters.Add("@senha", OleDbType.VarChar).Value = password;
                strSQL.Parameters.Add("@nascimento", OleDbType.VarChar).Value = cadastro.getNascimento();
                strSQL.Parameters.Add("@genero", OleDbType.VarChar).Value = cadastro.getGenero();
                strSQL.Parameters.Add("@usuario", OleDbType.VarChar).Value = cadastro.getNome();
                strSQL.Parameters.Add("@apelido", OleDbType.VarChar).Value = cadastro.getApelido();
                strSQL.Parameters.Add("@verifica", OleDbType.VarChar).Value = codigo;
                strSQL.Parameters.Add("@caminho", OleDbType.VarChar).Value = cadastro.getFotoPerfil();

                strSQL.ExecuteNonQuery();

                SmtpClient smtpClient = new SmtpClient("smtp.Office365.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("ls179841@alunos.unisanta.br", "17088274Luca@-");

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("ls179841@alunos.unisanta.br");
                mailMessage.To.Add(new MailAddress(cadastro.getEmail()));
                mailMessage.Subject = "Código de Verificação";
                mailMessage.Body = "Seu código de verificação é: " + codigo;

                smtpClient.Send(mailMessage);

                Verificação verificação = new Verificação(cadastro);
                verificação.ShowDialog();
                if(cadastro.getCodigo() == null)
                {
                    Erro.setErro("Cadastro falho!");
                    String aux1 = $"delete from TabCadastro where cd_Email = '{cadastro.getEmail()}'";
                    strSQL = new OleDbCommand(aux1, conexao);

                    strSQL.ExecuteNonQuery();

                }
            }
            catch
            {
                Erro.setErro("Email ja utilizado, se preferir, redefina a senha na página de Login!");
            }

        }
        public static void insiraCadastros(Credenciais cadastro)
        {
            String aux = "select * from TabCadastro where cd_Email = @email";
            strSQL = new OleDbCommand(aux, conexao);
            strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = cadastro.getEmail();

            resultado = strSQL.ExecuteReader();

            if (resultado.Read())
            {
                string nascimento = resultado.GetString(2);
                DateTime nasci = DateTime.Parse(nascimento);
                string genero = resultado.GetString(3);
                string nome = resultado.GetString(4);
                string apelido = resultado.GetString(5);

                cadastro.setNascimento(nasci);
                cadastro.setGenero(genero);
                cadastro.setNome(nome);
                cadastro.setApelido(apelido);

            }
            else
            {
                Erro.setErro("Cadastro falho!");
            }
        }
        public static void updateFoto(Credenciais cadastro)
        {
            String aux = "update TabCadastro set ds_Caminho=@caminho where cd_Email = @email";

            strSQL = new OleDbCommand(aux, conexao);
            strSQL.Parameters.Add("@caminho", OleDbType.VarChar).Value = cadastro.getFoto();
            strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = cadastro.getEmail();
            strSQL.ExecuteNonQuery();
        }
        public static string HashPassword(string password)
        {   
                using (var sha256 = SHA256.Create())
                {
                    var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                    var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                    return hash;
                }
        }
        public static void InsiraUmNome(Credenciais cadastro)
        {
                String aux = "insert into TabUsuario(cd_Usuario, nm_Usuario) values (@email, @usuario)";
                strSQL = new OleDbCommand(aux, conexao);

                Erro.setErro(false);
                try
                {
                    strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = cadastro.getEmail();
                    strSQL.Parameters.Add("@usuario", OleDbType.VarChar).Value = cadastro.getNome();

                    strSQL.ExecuteNonQuery();
                }
                catch
                {
                    Erro.setErro("ERRO!");
                }
        }
        public static void verificaCodigo(Credenciais cadastro)
        {
            String aux = "select * from TabCadastro where cd_Email = @email";
            strSQL = new OleDbCommand(aux, conexao);

            strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = cadastro.getEmail();

            resultado = strSQL.ExecuteReader();

            if (resultado.Read())
            {
                string codigo = resultado.GetString(6);

                Erro.setErro(false);
                if (cadastro.getCodigo() != codigo)
                {
                    Erro.setErro("Código Errado!");
                }
            }
        }
        public static void ConsultaEsqueci(Credenciais cadastro)
        {
            Random random = new Random();
            string codigo = random.Next(100000, 999999).ToString();

            SmtpClient smtpClient = new SmtpClient("smtp.Office365.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("ls179841@alunos.unisanta.br", "17088274Luca@-");
            Erro.setErro(false);
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("ls179841@alunos.unisanta.br");
                mailMessage.To.Add(new MailAddress(cadastro.getEmail()));
                mailMessage.Subject = "Código de Verificação";
                mailMessage.Body = "Seu código de verificação é: " + codigo;

                smtpClient.Send(mailMessage);

                String aux1 = "update TabCadastro set cd_Verifica=@verifica where cd_Email=@email";
                strSQL = new OleDbCommand(aux1, conexao);
                strSQL.Parameters.Add("@verifica", OleDbType.VarChar).Value = codigo;
                strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = cadastro.getEmail();
                strSQL.ExecuteNonQuery();

                Verificação verificação = new Verificação(cadastro);
                verificação.ShowDialog();
                if(cadastro.getCodigo() == null)
                {
                    Erro.setErro("Email não cadastrado!");
                }
            }
            catch
            {
                Erro.setErro("Email não cadastrado!");
            }
        }
        public static void AlteraEsqueci(Credenciais cadastro)
        {
            String aux1 = "update TabCadastro set cd_Senha=@senha where cd_Email=@email";
            strSQL = new OleDbCommand(aux1, conexao);

            Erro.setErro(false);

            string password = cadastro.getSenha();
            password = HashPassword(password);
            strSQL.Parameters.Add("@senha", OleDbType.VarChar).Value = password;
            strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = cadastro.getEmail();
            strSQL.ExecuteNonQuery();
        }

        public static void InsiraUmNomeLogin(Credenciais cadastro)
        {
            String aux = "select * from TabUsuario where cd_Usuario = @email";
            strSQL = new OleDbCommand(aux, conexao);
            strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = cadastro.getEmail();

            resultado = strSQL.ExecuteReader();


            Erro.setErro(false);
            if (resultado.Read())
            {
                cadastro.setNome(resultado.GetString(1));
            }
            else
            {
                Erro.setErro("Nome não cadastrado!");
            }
        }
        public static void InsiraUmPost(Credenciais cadastro)
        {
            String aux = "insert into TabPost(ds_Post, nm_Usuario) values (@post, @usuario)";
            strSQL = new OleDbCommand(aux, conexao);

            Erro.setErro(false);
            try
            {
                strSQL.Parameters.Add("@post", OleDbType.VarChar).Value = cadastro.getPost();
                strSQL.Parameters.Add("@usuario", OleDbType.VarChar).Value = cadastro.getEmail();

                strSQL.ExecuteNonQuery();
            }
            catch
            {
                Erro.setErro("ERRO!");
            }
        }
        public static List<Label> EscreveOsPost(Credenciais cadastro)
        {
            String aux = "select *  from TabAmizade where ds_Status = 'true'";
            strSQL = new OleDbCommand(aux, conexao);

            resultado = strSQL.ExecuteReader();
            List<string> emails = new List<string>();
            emails.Add(cadastro.getEmail());

            while (resultado.Read())
            {
                if (cadastro.getEmail() == resultado.GetString(1) && !emails.Contains(resultado.GetString(2))) { emails.Add(resultado.GetString(2)); }
                if (cadastro.getEmail() == resultado.GetString(2) && !emails.Contains(resultado.GetString(1))) { emails.Add(resultado.GetString(1)); }
            }
            List<Label> posts = new List<Label>();
            foreach (string email in emails)
            {
                String aux1 = $"select *  from TabPost where nm_Usuario = '{email}'";
                strSQL = new OleDbCommand(aux1, conexao);

                resultado = strSQL.ExecuteReader();
                while (resultado.Read())
                {
                    Label labelPost = new Label();
                    labelPost.Text = $"{resultado.GetString(1)}";
                    labelPost.Tag = $"{email}";
                    posts.Add(labelPost);
                }
            }
            return posts;
        }
        public static List<Image> EscreveAsImagens(Credenciais cadastro)
        {
            String aux = "select *  from TabAmizade where ds_Status = 'true'";
            strSQL = new OleDbCommand(aux, conexao);

            resultado = strSQL.ExecuteReader();
            List<string> emails = new List<string>();
            emails.Add(cadastro.getEmail());

            while (resultado.Read())
            {
                if (cadastro.getEmail() == resultado.GetString(1) && !emails.Contains(resultado.GetString(2))) { emails.Add(resultado.GetString(2)); }
                if (cadastro.getEmail() == resultado.GetString(2) && !emails.Contains(resultado.GetString(1))) { emails.Add(resultado.GetString(1)); }
            }
            List<Image> posts = new List<Image>();
            foreach (string email in emails)
            {
                String aux1 = $"select *  from TabFotos where nm_Autor = '{email}'";
                strSQL = new OleDbCommand(aux1, conexao);

                resultado = strSQL.ExecuteReader();
                List<string> caminhosImagens = new List<string>();
                while (resultado.Read())
                {
                    caminhosImagens.Add(resultado.GetString(1));
                }
                foreach (string caminhoImagem in caminhosImagens)
                {

                    Image imagem = Image.FromFile(caminhoImagem);
                    imagem.Tag = $"{email}";
                    posts.Add(imagem);
                }
            }
            return posts;
        }
        public static List<Label> EscreveOsPostPerfil(Credenciais cadastro)
        {
            String aux = "select * from TabPost where nm_Usuario = @usuario";
            strSQL = new OleDbCommand(aux, conexao);

            strSQL.Parameters.Add("@usuario", OleDbType.VarChar).Value = cadastro.getEmail();

            resultado = strSQL.ExecuteReader();

            List<Label> posts = new List<Label>();
            while (resultado.Read())
            {
                Label labelPost = new Label();
                labelPost.Text = resultado.GetString(1);
                posts.Add(labelPost);
            }
            return posts;
        }
        public static List<Image> EscreveAsImagensPerfil(Credenciais cadastro)
        {
            String aux = "select * from TabFotos where nm_Autor = @usuario";
            strSQL = new OleDbCommand(aux, conexao);

            strSQL.Parameters.Add("@usuario", OleDbType.VarChar).Value = cadastro.getEmail();

            resultado = strSQL.ExecuteReader();

            List<Image> posts = new List<Image>();
            List<string> caminhosImagens = new List<string>();
            while (resultado.Read())
            {
                caminhosImagens.Add(resultado.GetString(1));
            }
            foreach (string caminhoImagem in caminhosImagens)
            {
                Image imagem = Image.FromFile(caminhoImagem);
                posts.Add(imagem);
            }
            return posts;
        }
        
        public static Image ImagemPerfil(Credenciais cadastro)
        {
            

            String aux = "select ds_Caminho from TabCadastro where cd_Email = @usuario";
            strSQL = new OleDbCommand(aux, conexao);

            strSQL.Parameters.Add("@usuario", OleDbType.VarChar).Value = cadastro.getEmail();

            resultado = strSQL.ExecuteReader();

            Image posts = null;
            while (resultado.Read())
            {
                posts = Image.FromFile(resultado.GetString(0));
            }
            return posts;
        }
        public static void insiraFoto(Credenciais cadastro)
        {
            String aux = "insert into TabFotos (ds_Caminho, nm_Autor) values (@CaminhoArquivo, @Autor)";
            strSQL = new OleDbCommand(aux, conexao);

            Erro.setErro(false);
            try
            {
                strSQL.Parameters.Add("@CaminhoArquivo", OleDbType.VarChar).Value = cadastro.getFoto();
                strSQL.Parameters.Add("@Autor", OleDbType.VarChar).Value = cadastro.getEmail();

                strSQL.ExecuteNonQuery();
            }
            catch
            {
                Erro.setErro("ERRO!");
            }
        }
        public static List<string> SelecionaUsuarios(Credenciais cadastro)
        {
            String aux = "select * from TabUsuario where nm_Usuario = @usuario";
            strSQL = new OleDbCommand(aux, conexao);

            strSQL.Parameters.Add("@usuario", OleDbType.VarChar).Value = cadastro.getAmigo();

            resultado = strSQL.ExecuteReader();
            List<string> manda = new List<string>();

            while (resultado.Read())
            {
                if (resultado.GetString(0) != cadastro.getEmail())
                {
                    cadastro.setAmigos(resultado.GetString(0));
                    string envia = $"Nome: {resultado.GetString(1)} e Email: {resultado.GetString(0)}";
                    manda.Add(envia);
                }
            }

            return manda;
        }
        public static List<string> SelecionaTodosUsuarios(Credenciais cadastro)
        {
            String aux = "select * from TabUsuario";
            strSQL = new OleDbCommand(aux, conexao);

            resultado = strSQL.ExecuteReader();
            List<string> manda = new List<string>();

            while (resultado.Read())
            {
                if (resultado.GetString(0) != cadastro.getEmail())
                {
                    cadastro.setAmigos(resultado.GetString(0));
                    string envia = $"Nome: {resultado.GetString(1)} e Email: {resultado.GetString(0)}";
                    manda.Add(envia);
                }
            }

            return manda;
        }
        public static void Amizade(Credenciais cadastro)
        {
            String aux = "insert into TabAmizade (cd_Remetente, cd_Destinatario, ds_Status) values (@remetente, @destinatario, @status)";
            strSQL = new OleDbCommand(aux, conexao);

            Erro.setErro(false);
            try
            {
                strSQL.Parameters.Add("@remetente", OleDbType.VarChar).Value = cadastro.getEmail();
                strSQL.Parameters.Add("@destinatario", OleDbType.VarChar).Value = cadastro.getEmailAmigo();
                strSQL.Parameters.Add("@status", OleDbType.VarChar).Value = false;

                strSQL.ExecuteNonQuery();
            }
            catch
            {
                Erro.setErro("ERRO!");
            }
        }
        public static void VerificaAmizade(Credenciais cadastro)
        {
            String aux = "select * from TabAmizade where cd_Destinatario = @destinatario AND ds_Status = 'False' ";
            strSQL = new OleDbCommand(aux, conexao);

            strSQL.Parameters.Add("@destinatario", OleDbType.VarChar).Value = cadastro.getEmail();

            resultado = strSQL.ExecuteReader();

            while (resultado.Read())
            {
                cadastro.setAmigos(resultado.GetString(1));
            }
        }
        public static void UpdateAmigo(Credenciais cadastro)
        {
            String aux = "update TabAmizade set ds_Status=@status where cd_Destinatario = @destino";
            strSQL = new OleDbCommand(aux, conexao);

            strSQL.Parameters.Add("@status", OleDbType.VarChar).Value = true;
            strSQL.Parameters.Add("@destinatario", OleDbType.VarChar).Value = cadastro.getEmail();
            strSQL.ExecuteNonQuery();

        }
        public static List<string> SeusAmigos(Credenciais cadastro)
        {
            String aux = "select * from TabAmizade where ds_Status = 'True'";
            strSQL = new OleDbCommand(aux, conexao);

            resultado = strSQL.ExecuteReader();
            List<string> manda = new List<string>();

            while (resultado.Read())
            {
                if (resultado.GetString(1) == cadastro.getEmail() || resultado.GetString(2) == cadastro.getEmail())
                {
                    if (resultado.GetString(1) == cadastro.getEmail())
                    { 
                        cadastro.setAmigos1(resultado.GetString(2));
                        string envia = $"Email: {resultado.GetString(2)}";
                        manda.Add(envia);
                    }
                    else
                    {
                        cadastro.setAmigos1(resultado.GetString(1));
                        string envia = $"Email: {resultado.GetString(1)}";
                        manda.Add(envia);
                    }
                    
                }
            }

            return manda;
        }
        public static Image FotoPost(string cadastro)
        {
            String aux = $"select ds_Caminho from TabCadastro where cd_Email = '{cadastro}'";
            strSQL = new OleDbCommand(aux, conexao);

            resultado = strSQL.ExecuteReader();
            Image posts = null;
            while (resultado.Read())
            {
                posts = Image.FromFile(resultado.GetString(0));
            }
            return posts;
        }
        public static void FotoPerfilAmigo(Credenciais cadastro)
        {
            String aux = $"select * from TabCadastro where cd_Email = '{cadastro.getEmail()}'";
            strSQL = new OleDbCommand(aux, conexao);

            resultado = strSQL.ExecuteReader();

            if(resultado.Read())
            {
                cadastro.setNome(resultado.GetString(4));
                cadastro.setGenero(resultado.GetString(3));
                cadastro.setApelido(resultado.GetString(5));
            }

        }
        public static void UpdatePerfil(Credenciais cadastro)
        {
            String aux = $"update TabCadastro set ds_Genero= '{cadastro.getGenero()}', nm_Usuário = '{cadastro.getNome()}', nm_Apelido = '{cadastro.getApelido()}' where cd_Email = '{cadastro.getEmail()}'";
            strSQL = new OleDbCommand(aux, conexao);
            strSQL.ExecuteNonQuery();

        }
        public static void setaDados(Credenciais cadastro)
        {
            String aux = $"select * from TabCadastro where cd_Email = '{cadastro.getEmail()}'";
            strSQL = new OleDbCommand(aux, conexao);

            resultado = strSQL.ExecuteReader();

            if (resultado.Read())
            {
                cadastro.setNome(resultado.GetString(4));
                cadastro.setGenero(resultado.GetString(3));
                cadastro.setApelido(resultado.GetString(5));
            }

        }
    }
}
