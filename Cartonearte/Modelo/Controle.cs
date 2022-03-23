
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
namespace Cartonearte
{
    public class Controle
    { 
        
        public bool tem;
        public string msg ="";

        public bool acessar(string login,string senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login,senha);
            if (!loginDao.msg.Equals(""))
            {
                this.msg = loginDao.msg;
            }
            else
            {

            }

                return tem;
        }
        public bool conferiremail(string login,string tabela)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificaremail(login,tabela);
            if (!loginDao.msg.Equals(""))
            {
                this.msg = loginDao.msg;
            }
            else
            {

            }

            return tem;
        }
        public string cadastrar(string email,string senha,string nome,string cpf,string tipo,string cidade,string estado,string bairro,string rua,string numero,string cep)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.msg = loginDao.cadastrar(email, senha, nome, cpf, tipo, cidade, estado, bairro, rua,numero, cep);
            if (loginDao.tem)
            {
                this.tem = true;
                
            }
            return msg;
        }
        public string cadastroProduto(string nome, string tamanho, string quantidade, string descricao, string preco, string foto)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.msg = loginDao.cadastroProduto(nome,tamanho,quantidade,descricao,preco,foto);
            if (loginDao.tem)
            {
                this.tem = true;

            }
            return msg;
        }
        public string vendas(string data_entrega, string data_venda, Double valor, string cliente_cod, string usuario_cod, string tipo)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.msg = loginDao.vendas(data_entrega, data_venda, valor, cliente_cod, usuario_cod, tipo);
            if (loginDao.tem)
            {
                this.tem = true;

            }
            return msg;
        }
       
        public bool validarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        /// <summary>
        /// Realiza a validação do CPF
        /// </summary>

            public  bool IsCpf(string cpf)
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                int soma;
                int resto;
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                    return false;
                tempCpf = cpf.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
                return cpf.EndsWith(digito);
            }
        }
    }


