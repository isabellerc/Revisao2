using H1Store.Catalogo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.Interfaces
{
	public interface IJogoService
	{
        IEnumerable<JogoViewModel> ObterTodos();
        void Adicionar(NovoJogoViewModel jogo);
    }
}
