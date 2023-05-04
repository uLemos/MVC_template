using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            var pessoa = new PessoaModelView();

            pessoa.Name = "Você";
            pessoa.LastName = "Não viu";
            pessoa.EndName = "Nada";

            return View(pessoa);
        }

        [HttpPost] //Puxa o Required de "PessoaModelView"
        public IActionResult Save(PessoaModelView pessoa)
        {
            if (ModelState.IsValid)
            {
                //Aqui é aplicada a condição caso seja válida a ModelState(onde estão as nossas variáveis implementadas na view)
            }
        }
    }
}
