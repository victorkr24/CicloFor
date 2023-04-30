using Microsoft.AspNetCore.Mvc;

namespace CicloFor.Controllers
{
    public class CicloController : Controller
    {
        public IActionResult Index()
        {
            var resultados = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                resultados.Add(i);
            }

            return View(resultados);
        }
    }
}
