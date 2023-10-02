using H1Store.Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Domain.Interfaces
{
	public interface IJogoRepository
	{
		IEnumerable<Jogo> ObterTodos();
		Task<Jogo> ObterPorId(Guid id);
		Task<IEnumerable<Jogo>> ObterPorCategoria(int codigo);

		void Adicionar(Jogo jogo);
		void Atualizar(Jogo jogo);
	}
}
