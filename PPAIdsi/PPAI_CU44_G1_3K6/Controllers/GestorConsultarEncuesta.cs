using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PPAI_CU44_G1_3K6.Entidades;
using PPAI_CU44_G1_3K6.ViewModel;
using System.Text;

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
                id = 1,
                fechaHoraInicio = new DateTime(2023, 04, 04, 10, 20, 00),
                fechaHoraFin = null,
                estado = inicial,
            };

            CambioDeEstado cambioEstado2 = new CambioDeEstado
            {
                id = 2,
                fechaHoraInicio = new DateTime(2023, 03, 03, 10, 20, 00),
                fechaHoraFin = new DateTime(2023, 03, 03, 10, 20, 30),
                estado = inicial,
            };

            CambioDeEstado cambioEstado3 = new CambioDeEstado
            {
                id = 3,
                fechaHoraInicio = new DateTime(2023, 03, 04, 10, 20, 00),
                fechaHoraFin = null,
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

            RespuestaPosible respuesta3 = new RespuestaPosible
            {
                valor = "3",
                descripcion = "Malo"
            };

            RespuestaPosible respuesta4 = new RespuestaPosible
            {
                valor = "5",
                descripcion = "Regular"
            };

            RespuestaPosible respuesta5 = new RespuestaPosible
            {
                valor = "5",
                descripcion = "Bueno"
            };

            //Pregunta
            Pregunta pregunta1 = new Pregunta
            {
                valor = 1,
                pregunta = "¿Solucionamos su consulta?",
                respuesta = new List<RespuestaPosible> { respuesta1, respuesta2 }
            };

            Pregunta pregunta2 = new Pregunta
            {
                valor = 2,
                pregunta = "Describa el servicio",
                respuesta = new List<RespuestaPosible> { respuesta3, respuesta4, respuesta5 }
            };

            //Encuesta
            Encuesta encuestaSatisfaccion = new Encuesta
            {
                id = 1,
                descripcion = "Encuesta de satisfacción",
                fechaFinVigencia = new DateTime(2024, 04, 04, 10, 20, 00),
                preguntas = new List<Pregunta> { pregunta1, pregunta2 }
            };

            //RespuestaDeCliente
            RespuestaDeCliente respuestaCliente1 = new RespuestaDeCliente
            {
                id = 1,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta1
            };

            RespuestaDeCliente respuestaCliente2 = new RespuestaDeCliente
            {
                id = 2,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta2
            };

            RespuestaDeCliente respuestaCliente3 = new RespuestaDeCliente
            {
                id = 3,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta4
            };

            RespuestaDeCliente respuestaCliente4 = new RespuestaDeCliente
            {
                id = 4,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta5
            };

            //Llamadas

            Llamada llamada1 = new Llamada
            {
                id = 1,
                descripcionOperador = 1,
                detalleAccionRequerida = 1,
                duracion = 3,
                encuestaEnviada = 1,
                observacionAuditor = 1,
                cliente = cliente2,
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado1 },
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente2, respuestaCliente3 }
            };

            Llamada llamada2 = new Llamada
            {
                id = 2,
                descripcionOperador = 2,
                detalleAccionRequerida = 1,
                duracion = 5,
                encuestaEnviada = 1,
                observacionAuditor = 1,
                cliente = cliente1,
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado2, cambioEstado3 },
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente1, respuestaCliente4 }
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

        [HttpPost]
        [Route("api/tomarSeleccionLlamada")]
        //crear objeto llamadaseleccionada
        //string nombre, string estado, string duracion, string descripcionEncuesta, lista de objetos de abajo

        //creo objeto PreguntaRespuesta y paso lista de esos
        //atributos:
        //string pregunta, string respuesta
        public LlamadaSeleccionada tomarSeleccionLlamada(Llamada seleccionadoLlamada)
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
                id = 1,
                fechaHoraInicio = new DateTime(2023, 04, 04, 10, 20, 00),
                fechaHoraFin = null,
                estado = inicial,
            };

            CambioDeEstado cambioEstado2 = new CambioDeEstado
            {
                id = 2,
                fechaHoraInicio = new DateTime(2023, 03, 03, 10, 20, 00),
                fechaHoraFin = new DateTime(2023, 03, 03, 10, 20, 30),
                estado = inicial,
            };

            CambioDeEstado cambioEstado3 = new CambioDeEstado
            {
                id = 3,
                fechaHoraInicio = new DateTime(2023, 03, 04, 10, 20, 00),
                fechaHoraFin = null,
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

            RespuestaPosible respuesta3 = new RespuestaPosible
            {
                valor = "3",
                descripcion = "Malo"
            };

            RespuestaPosible respuesta4 = new RespuestaPosible
            {
                valor = "5",
                descripcion = "Regular"
            };

            RespuestaPosible respuesta5 = new RespuestaPosible
            {
                valor = "5",
                descripcion = "Bueno"
            };

            //Pregunta
            Pregunta pregunta1 = new Pregunta
            {
                valor = 1,
                pregunta = "¿Solucionamos su consulta?",
                respuesta = new List<RespuestaPosible> { respuesta1, respuesta2 }
            };

            Pregunta pregunta2 = new Pregunta
            {
                valor = 2,
                pregunta = "Describa el servicio",
                respuesta = new List<RespuestaPosible> { respuesta3, respuesta4, respuesta5 }
            };

            //Encuesta
            Encuesta encuestaSatisfaccion = new Encuesta
            {
                id = 1,
                descripcion = "Encuesta de satisfacción",
                fechaFinVigencia = new DateTime(2024, 04, 04, 10, 20, 00),
                preguntas = new List<Pregunta> { pregunta1, pregunta2 }
            };

            //RespuestaDeCliente
            RespuestaDeCliente respuestaCliente1 = new RespuestaDeCliente
            {
                id = 1,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta1
            };

            RespuestaDeCliente respuestaCliente2 = new RespuestaDeCliente
            {
                id = 2,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta2
            };

            RespuestaDeCliente respuestaCliente3 = new RespuestaDeCliente
            {
                id = 3,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta4
            };

            RespuestaDeCliente respuestaCliente4 = new RespuestaDeCliente
            {
                id = 4,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta5
            };

            //Llamadas

            Llamada llamada1 = new Llamada
            {
                id = 1,
                descripcionOperador = 1,
                detalleAccionRequerida = 1,
                duracion = 3,
                encuestaEnviada = 1,
                observacionAuditor = 1,
                cliente = cliente2,
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado1 },
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente2, respuestaCliente3 }
            };

            Llamada llamada2 = new Llamada
            {
                id = 2,
                descripcionOperador = 2,
                detalleAccionRequerida = 1,
                duracion = 5,
                encuestaEnviada = 1,
                observacionAuditor = 1,
                cliente = cliente1,
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado2, cambioEstado3 },
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente1, respuestaCliente4 }
            };

            List<Llamada> llamadas = new List<Llamada> { llamada1, llamada2 };
            #endregion
            #region seleccion
            Llamada seleccion = new Llamada();
            foreach(var llamada in llamadas)
            {
                if (llamada.id == seleccionadoLlamada.id)
                {
                    seleccion = llamada;
                    break;
                }
            }
            #endregion

            return obtenerDatosLlamada();
            LlamadaSeleccionada obtenerDatosLlamada()
            {
                LlamadaSeleccionada llamadaSeleccionada = seleccion.getDatosLlamada();
                Encuesta enc = new Encuesta();
                var (encuesta, preguntas, respuestas) = enc.esEncuestaDeCliente(seleccion.encuestaEnviada);
                llamadaSeleccionada.descripcionEncuesta = encuesta.getDescipcion();
                List<string> descripcionPreguntas = encuesta.obtenerDescripcionPregunta(preguntas);
                List<string> respuestasCliente = new List<string>();
                respuestasCliente = seleccion.obtenerRespuestas(respuestas);
                var contador = 0;
                List<PreguntaRespuesta> preguntaRespuesta = new List<PreguntaRespuesta>();
                foreach (string descripcion in descripcionPreguntas)
                {
                    PreguntaRespuesta pregRes = new PreguntaRespuesta
                    {
                        pregunta = descripcion,
                        respuesta = respuestasCliente.ElementAt(contador)
                    };
                    preguntaRespuesta.Add(pregRes);
                    contador++;
                }
                llamadaSeleccionada.preguntaRespuestas = preguntaRespuesta;
                return llamadaSeleccionada;
            }
        }


        [HttpPost]
        [Route("api/tomarOpcionDeImpresion")]
        //recibo objeto llamadaSeleccionada
        //devuelvo el csv creado
        public string tomarOpcionDeImpresion(LlamadaSeleccionada llamadaSelec)
        {
            return generarCSV(llamadaSelec);
            string generarCSV(LlamadaSeleccionada llamadaSeleccionada)
            {
                string csv = llamadaSeleccionada.nombre.ToString() + "," + llamadaSeleccionada.estado.ToString() + "," + llamadaSeleccionada.duracion.ToString();
                foreach (var pregunta in llamadaSeleccionada.preguntaRespuestas)
                {
                    string pregRes = "\n►" + pregunta.pregunta + "," + pregunta.respuesta + "◄";
                    csv = string.Concat(csv, pregRes);
                }
                var llamarMetodo = new LlamadaSeleccionada();
                return llamarMetodo.generarCSV(csv);
            };
        }
    }
}
