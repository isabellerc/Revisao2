using AutoMapper;
using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Domain.Entities;
using H1Store.Catalogo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.Services
{
	public class JogoService : IJogoService
	{
        #region - Construtores
        private readonly IJogoRepository _jogoRepository;
        private IMapper _mapper;

        public JogoService(IJogoRepository jogoRepository, IMapper mapper)
        {
            _jogoRepository = jogoRepository;
            _mapper = mapper;
        }
        #endregion

        #region - Funções
        public void Adicionar(NovoJogoViewModel novoJogoViewModel)
        {
            var novoJogo = _mapper.Map<Jogo>(novoJogoViewModel);
            _jogoRepository.Adicionar(novoJogo);

        }


        public IEnumerable<JogoViewModel> ObterTodos()
        {
            return _mapper.Map<IEnumerable<JogoViewModel>>(_jogoRepository.ObterTodos());
        }
        #endregion
    }
}
