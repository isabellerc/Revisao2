using AutoMapper;
using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
        public ApplicationToDomain()
        {

            CreateMap<JogoViewModel, Jogo>()
               .ConstructUsing(q => new Jogo(q.Codigo, q.Nome, q.Idade, q.Cpf, q.primeiroNro, q.segundoNro, q.terceiroNro, q.quartoNro, q.quintoNro, q.sextoNro, q.dataJogo));



            CreateMap<NovoJogoViewModel, Jogo>()
                   .ConstructUsing(q => new Jogo(0, q.Nome, q.Idade, q.Cpf, q.primeiroNro, q.segundoNro, q.terceiroNro, q.quartoNro, q.quintoNro, q.sextoNro, q.dataJogo));

        }
    }
}
