using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppCurriculoIghorMoura.Models;

namespace WebAppCurriculoIghorMoura.Controllers
{
    public class CurriculoController : Controller
    {   

        [Route("")]
        [Route("Curriculo")]
        [Route("Curriculo/Cadastro")]
        public IActionResult Curriculo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(CurriculoController curriculo)
        {
            return View();
        }
    }
}
