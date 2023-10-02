using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace H1Store.Catalogo.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class JogoController : ControllerBase
	{
		private readonly IJogoService _jogoService;

		public JogoController(IJogoService jogoService)
		{
			_jogoService = jogoService;
		}

		[HttpPost(Name = "Adicionar")]
		public IActionResult Post(NovoJogoViewModel novoJogoViewModel)
		{
			_jogoService.Adicionar(novoJogoViewModel);

			return Ok();
		}


		[HttpGet(Name = "ObterTodos")]
		public IActionResult Get()
		{
			return Ok(_jogoService.ObterTodos());
		}
	}
}
