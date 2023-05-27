using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PPAI_CU44_G1_3K6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GestorConsultarEncuesta : Controller
    {
        [HttpGet]
        public bool tomarOpcionCE()
        {
            return true;
        }

        [HttpGet]
        [Route("api/tomarPeriodo")]
        public List<string> tomarPeriodo()
        {
            var lista = new List<string>();
            lista.Add("llamada1");
            lista.Add("llamada2");
            lista.Add("llamada3");
            return lista;
        }
    }
}
