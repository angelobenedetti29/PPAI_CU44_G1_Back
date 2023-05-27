using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PPAI_CU44_G1_3K6.Entidades;

namespace PPAI_CU44_G1_3K6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GestorConsultarEncuesta : Controller
    {
        [HttpGet]
        [Route("api/tomarOpcionCE")]
        public bool tomarOpcionCE()
        {
            return true;
        }

        [HttpGet]
        [Route("api/tomarPeriodo")]
        //devuelve lista de objetos llamada
        public List<string> tomarPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            var lista = new List<string>();
            lista.Add("llamada1");
            lista.Add("llamada2");
            lista.Add("llamada3");
            return lista;
        }

        [HttpGet]
        [Route("api/tomarSeleccionLlamada")]
        //crear objeto llamadaseleccionada
        //string nombre, string estado, string duracion, string descripcionEncuesta, lista de objetos de abajo

        //creo objeto PreguntaRespuesta y paso lista de esos
        //atributos:
        //string pregunta, string respuesta
        public void tomarSeleccionLlamada(Llamada seleccionadoLlamada)
        {

        }


        [HttpGet]
        [Route("api/tomarOpcionDeImpresion")]
        //recibo objeto llamadaSeleccionada
        //devuelvo el csv creado
        public string tomarOpcionDeImpresion()
        {
            return "devolucion";
        }
    }
}
