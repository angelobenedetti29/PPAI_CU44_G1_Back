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
        public List<Llamada> tomarPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            #region objetos
            //Clientes
            Cliente cliente1 = new Cliente
            {
                dni = 42977233,
                nombreCompleto = "Gustavo Cerati",
                numeroCelular = 3511234567,
            };

            Cliente cliente2 = new Cliente
            {
                dni = 42897654,
                nombreCompleto = "Carlos Alberto Garcia",
                numeroCelular = 2012012012,
            };

            //Estados
            Estado inicial = new Estado
            {
                nombre = "Inicial"
            };

            Estado finalizado = new Estado
            {
                nombre = "Finalizado"
            };

            //CambioEstado
            CambioDeEstado cambioEstado1 = new CambioDeEstado
            {
                fechaHoraInicio = new DateTime(2023, 04, 04, 10, 20, 00),
                estado = inicial,
            };

            CambioDeEstado cambioEstado2 = new CambioDeEstado
            {
                fechaHoraInicio = new DateTime(2023, 03, 03, 10, 20, 00),
                estado = inicial,
            };

            CambioDeEstado cambioEstado3 = new CambioDeEstado
            {
                fechaHoraInicio = new DateTime(2023, 03, 04, 10, 20, 00),
                estado = finalizado,
            };

            //RespuestaPosible
            RespuestaPosible respuesta1 = new RespuestaPosible
            {
                valor = "1",
                descripcion = "Si"
            };
            RespuestaPosible respuesta2 = new RespuestaPosible
            {
                valor = "2",
                descripcion = "No"
            };

            //Pregunta
            Pregunta pregunta1 = new Pregunta
            {
                pregunta = "¿Solucionamos su consulta?",
                respuesta = new List<RespuestaPosible> { respuesta1, respuesta2 }
            };

            //Encuesta
            Encuesta encuestaSatisfaccion = new Encuesta
            {
                descripcion = "Encuesta de satisfacción",
                fechaFinVigencia = new DateTime(2024, 04, 04, 10, 20, 00),
                preguntas = new List<Pregunta> { pregunta1 }
            };

            //RespuestaDeCliente
            RespuestaDeCliente respuestaCliente1 = new RespuestaDeCliente
            {
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta1
            };

            RespuestaDeCliente respuestaCliente2 = new RespuestaDeCliente
            {
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta2
            };

            //Llamadas

            Llamada llamada1 = new Llamada
            {
                descripcionOperador = 1,
                detalleAccionRequerida = 1,
                duracion = 3,
                encuestaEnviada = 1,
                observacionAuditor = 1,
                cliente = cliente2,
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado1 },
                respuestaDeCliente = respuestaCliente2
            };

            Llamada llamada2 = new Llamada
            {
                descripcionOperador = 2,
                detalleAccionRequerida = 1,
                duracion = 5,
                encuestaEnviada = 1,
                observacionAuditor = 1,
                cliente = cliente1,
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado2, cambioEstado3 },
                respuestaDeCliente = respuestaCliente1
            };

            List<Llamada> llamadas = new List<Llamada> { llamada1, llamada2 };
            #endregion

            List<Llamada> lista = buscarLlamadasConEncRespondidas(llamadas, fechaInicio, fechaFin);
            return lista;

            List<Llamada> buscarLlamadasConEncRespondidas(List<Llamada> posiblesLlamadas, DateTime fechaInicio, DateTime fechaFin)
            {
                List<Llamada> llamadasPeriodo = new List<Llamada>();
                foreach (var llamada in posiblesLlamadas)
                {
                    if ((llamada.tieneEncRespondidas(fechaInicio, fechaFin)))
                    {
                        llamadasPeriodo.Add(llamada);
                    }
                }
                return llamadasPeriodo;
            }
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
