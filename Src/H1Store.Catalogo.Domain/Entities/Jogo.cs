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
		public Jogo(int codigo, string nome, int idade, string cpf, int primeiroNro, int segundoNro, int terceiroNro, int quartoNro, int quintoNro, int sextoNro, DateTime dataJogo)
		{
			Codigo = codigo;
			Nome = nome;
			Idade = Idade;
			Cpf = Cpf;
			primeiroNro = primeiroNro;
			segundoNro = segundoNro;
			terceiroNro = terceiroNro;
			quartoNro = quartoNro;
			quintoNro = quintoNro;
			sextoNro = sextoNro;
			dataJogo = dataJogo;
		}

        //public Jogo(int codigo, string nome, int idade, string cpf, int primeiroNro, int segundoNro, int terceiroNro, int quartoNro, int quintoNro, int sextoNro, DateTime dataJogo)
        //{
        //    Codigo = codigo;
        //    Nome = nome;
        //    Idade = Idade;
        //    Cpf = Cpf;
        //    primeiroNro = primeiroNro;
        //    segundoNro = segundoNro;
        //    terceiroNro = terceiroNro;
        //    quartoNro = quartoNro;
        //    quintoNro = quintoNro;
        //    sextoNro = sextoNro;
        //    dataJogo = dataJogo;
        //}


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
		public string dataJogo { get; set; }
       

        #endregion

        #region 3 - Comportamentos

        //       public void Ativar() => Ativo = true;

        //	public void Desativar() => Ativo = false;

        //	public void AlterarDescricao(string descricao) => Descricao = descricao;

        //	public void DebitarEstoque(int quantidade)
        //	{
        //		if (!PossuiEstoque(quantidade)) throw new Exception("Estoque insuficiente");
        //		QuantidadeEstoque -= quantidade;
        //	}

        //	public void ReporEstoque(int quantidade)
        //	{
        //		QuantidadeEstoque += quantidade;
        //	}

        //	public bool PossuiEstoque(int quantidade) => QuantidadeEstoque >= quantidade;

        //	public void SetaCodigoProduto(int novocodigo) => Codigo = novocodigo;

        //	#endregion
        //}
        #endregion
    }
}
