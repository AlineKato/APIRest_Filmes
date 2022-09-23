using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Filme.Controllers
{
    //definir controlador 
    [ApiController]
    //explicitar qual é rota dele, que seria controller
    [Route("[controller]")]
    public class FilmeController : Controller
    {
        private static List<Filme> filmes = new List<Filme>();

        [HttpPost]
        public void AdicionaFilme (Filme filmes){

            filmes.Add(filmes);
        }
    }
}