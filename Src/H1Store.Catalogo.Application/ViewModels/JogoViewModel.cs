using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.ViewModels
{
	public class JogoViewModel
	{
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
    }
}
