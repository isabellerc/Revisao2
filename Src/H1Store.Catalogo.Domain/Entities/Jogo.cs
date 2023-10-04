using H1Store.Catalogo.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Domain.Entities
{
	public class Jogo
	{

        #region 1 - Contrutores
        public Jogo(int codigo, string nome, int idade, string cpf, int primeironro, int segundonro, int terceironro, int quartonro, int quintonro, int sextonro, DateTime datajogo)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            primeiroNro = primeironro;
            segundoNro = segundonro;
            terceiroNro = terceironro;
            quartoNro = quartonro;
            quintoNro = quintonro;
            sextoNro = sextonro;
            dataJogo = datajogo;
        }
        #endregion

        #region 2 - Propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public int primeiroNro { get; set; }
        public int segundoNro { get; set; }
        public int terceiroNro { get; set; }
        public int quartoNro { get; set; }
        public int quintoNro { get; set; }
        public int sextoNro { get; set; }
        public DateTime dataJogo { get; set; }

        #endregion

    }
}
