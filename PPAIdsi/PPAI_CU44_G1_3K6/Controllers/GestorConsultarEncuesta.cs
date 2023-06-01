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
                nombreCompleto = "Gustavo Adrian Cerati",
                numeroCelular = 3511234567,
            };

            Cliente cliente2 = new Cliente
            {
                dni = 42897654,
                nombreCompleto = "Carlos Alberto Garcia",
                numeroCelular = 3512012012,
            };

            Cliente cliente3 = new Cliente
            {
                dni = 35897635,
                nombreCompleto = "Federico Moura",
                numeroCelular = 3519122018,
            };

            Cliente cliente4 = new Cliente
            {
                dni = 36380465,
                nombreCompleto = "Cristian Gabriel Alvarez",
                numeroCelular = 3516380465,
            };

            Cliente cliente5 = new Cliente
            {
                dni = 20020020,
                nombreCompleto = "Patricio Santos Fontanet",
                numeroCelular = 3040274720,
            };

            //Estados
            Estado inicial = new Estado
            {
                nombre = "Inicial"
            };

            Estado reconectando = new Estado
            {
                nombre = "Reconectando"
            };

            Estado reconectado = new Estado
            {
                nombre = "Reconectado"
            };

            Estado finalizado = new Estado
            {
                nombre = "Finalizado"
            };

            //CambioEstado
            CambioDeEstado cambioEstado1 = new CambioDeEstado
            {
                id = 1,
                fechaHoraInicio = new DateTime(2023, 04, 04),
                fechaHoraFin = new DateTime(2023, 04, 04),
                estado = inicial,
            };

            CambioDeEstado cambioEstado14 = new CambioDeEstado
            {
                id = 3,
                fechaHoraInicio = new DateTime(2023, 04, 04),
                fechaHoraFin = null,
                estado = finalizado,
            };

            CambioDeEstado cambioEstado2 = new CambioDeEstado
            {
                id = 2,
                fechaHoraInicio = new DateTime(2023, 05, 03),
                fechaHoraFin = new DateTime(2023, 05, 03),
                estado = inicial,
            };

            CambioDeEstado cambioEstado3 = new CambioDeEstado
            {
                id = 3,
                fechaHoraInicio = new DateTime(2023, 05, 04),
                fechaHoraFin = null,
                estado = finalizado,
            };

            CambioDeEstado cambioEstado4 = new CambioDeEstado
            {
                id = 4,
                fechaHoraInicio = new DateTime(2023, 04, 04),
                fechaHoraFin = new DateTime(2023, 04, 04),
                estado = inicial,
            };

            CambioDeEstado cambioEstado5 = new CambioDeEstado
            {
                id = 5,
                fechaHoraInicio = new DateTime(2023, 05, 04),
                fechaHoraFin = new DateTime(2023, 05, 04),
                estado = reconectando,
            };

            CambioDeEstado cambioEstado6 = new CambioDeEstado
            {
                id = 6,
                fechaHoraInicio = new DateTime(2023, 05, 04),
                fechaHoraFin = new DateTime(2023, 05, 04),
                estado = reconectado,
            };

            CambioDeEstado cambioEstado7 = new CambioDeEstado
            {
                id = 7,
                fechaHoraInicio = new DateTime(2023, 05, 04),
                fechaHoraFin = null,
                estado = finalizado,
            };

            CambioDeEstado cambioEstado8 = new CambioDeEstado
            {
                id = 8,
                fechaHoraInicio = new DateTime(2023, 05, 04),
                fechaHoraFin = new DateTime(2023, 05, 04),
                estado = inicial,
            };

            CambioDeEstado cambioEstado9 = new CambioDeEstado
            {
                id = 9,
                fechaHoraInicio = new DateTime(2023, 05, 04),
                fechaHoraFin = new DateTime(2023, 05, 04),
                estado = reconectando,
            };

            CambioDeEstado cambioEstado10 = new CambioDeEstado
            {
                id = 10,
                fechaHoraInicio = new DateTime(2023, 05, 04),
                fechaHoraFin = new DateTime(2023, 05, 04),
                estado = reconectado,
            };

            CambioDeEstado cambioEstado11 = new CambioDeEstado
            {
                id = 1,
                fechaHoraInicio = new DateTime(2023, 05, 04),
                fechaHoraFin = null,
                estado = finalizado,
            };

            CambioDeEstado cambioEstado12 = new CambioDeEstado
            {
                id = 12,
                fechaHoraInicio = new DateTime(2023, 05, 03),
                fechaHoraFin = new DateTime(2023, 05, 03),
                estado = inicial,
            };

            CambioDeEstado cambioEstado13 = new CambioDeEstado
            {
                id = 13,
                fechaHoraInicio = new DateTime(2023, 05, 04),
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
                valor = "4",
                descripcion = "Regular"
            };

            RespuestaPosible respuesta5 = new RespuestaPosible
            {
                valor = "5",
                descripcion = "Bueno"
            };

            RespuestaPosible respuesta6 = new RespuestaPosible
            {
                valor = "6",
                descripcion = "1 a 3"
            };

            RespuestaPosible respuesta7 = new RespuestaPosible
            {
                valor = "7",
                descripcion = "3 o más"
            };

            RespuestaPosible respuesta8 = new RespuestaPosible
            {
                valor = "8",
                descripcion = "1"
            };

            RespuestaPosible respuesta9 = new RespuestaPosible
            {
                valor = "9",
                descripcion = "2"
            };

            RespuestaPosible respuesta10 = new RespuestaPosible
            {
                valor = "10",
                descripcion = "3"
            };

            RespuestaPosible respuesta11 = new RespuestaPosible
            {
                valor = "11",
                descripcion = "4"
            };

            RespuestaPosible respuesta12 = new RespuestaPosible
            {
                valor = "12",
                descripcion = "5"
            };

            RespuestaPosible respuesta13 = new RespuestaPosible
            {
                valor = "13",
                descripcion = "si"
            };
            RespuestaPosible respuesta14 = new RespuestaPosible
            {
                valor = "14",
                descripcion = "no"
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


            Pregunta pregunta3 = new Pregunta
            {
                valor = 3,
                pregunta = "¿Cuantas veces al mes solicita nuestra ayuda?",
                respuesta = new List<RespuestaPosible> { respuesta6, respuesta7 }
            };

            Pregunta pregunta4 = new Pregunta
            {
                valor = 4,
                pregunta = "Puntue del 1 al 5 la calidad de la llamada",
                respuesta = new List<RespuestaPosible> { respuesta8, respuesta9, respuesta10, respuesta11, respuesta12 }
            };

            Pregunta pregunta5 = new Pregunta
            {
                valor = 5,
                pregunta = "¿Se perdio la conexion de la llamada en algun momento?",
                respuesta = new List<RespuestaPosible> { respuesta13, respuesta14 }
            };

            //Encuesta
            Encuesta encuestaSatisfaccion = new Encuesta
            {
                id = 1,
                descripcion = "Encuesta de satisfacción",
                fechaFinVigencia = new DateTime(2024, 04, 04),
                preguntas = new List<Pregunta> { pregunta1, pregunta2, pregunta3 }
            };

            Encuesta encuestaCalidadLlamada = new Encuesta
            {
                id = 2,
                descripcion = "Encuesta de calidad de llamada",
                fechaFinVigencia = new DateTime(2024, 03, 03),
                preguntas = new List<Pregunta> { pregunta4, pregunta5 }
            };

            //RespuestaDeCliente
            RespuestaDeCliente respuestaCliente1 = new RespuestaDeCliente
            {
                id = 1,
                fechaEncuesta = new DateTime(2023, 05, 05),
                respuestaPosible = respuesta1
            };

            RespuestaDeCliente respuestaCliente2 = new RespuestaDeCliente
            {
                id = 2,
                fechaEncuesta = new DateTime(2023, 05, 05),
                respuestaPosible = respuesta2
            };

            RespuestaDeCliente respuestaCliente3 = new RespuestaDeCliente
            {
                id = 3,
                fechaEncuesta = new DateTime(2023, 05, 05),
                respuestaPosible = respuesta4
            };

            RespuestaDeCliente respuestaCliente4 = new RespuestaDeCliente
            {
                id = 4,
                fechaEncuesta = new DateTime(2023, 05, 05),
                respuestaPosible = respuesta5
            };

            RespuestaDeCliente respuestaCliente5 = new RespuestaDeCliente
            {
                id = 5,
                fechaEncuesta = new DateTime(2023, 05, 05),
                respuestaPosible = respuesta7
            };

            RespuestaDeCliente respuestaCliente6 = new RespuestaDeCliente
            {
                id = 6,
                fechaEncuesta = new DateTime(2023, 05, 05),
                respuestaPosible = respuesta6
            };

            RespuestaDeCliente respuestaCliente7 = new RespuestaDeCliente
            {
                id = 7,
                fechaEncuesta = new DateTime(2023, 05, 05),
                respuestaPosible = respuesta8
            };

            RespuestaDeCliente respuestaCliente8 = new RespuestaDeCliente
            {
                id = 8,
                fechaEncuesta = new DateTime(2023, 05, 05),
                respuestaPosible = respuesta14
            };

            RespuestaDeCliente respuestaCliente9 = new RespuestaDeCliente
            {
                id = 9,
                fechaEncuesta = new DateTime(2023, 05, 05),
                respuestaPosible = respuesta10
            };

            RespuestaDeCliente respuestaCliente10 = new RespuestaDeCliente
            {
                id = 10,
                fechaEncuesta = new DateTime(2023, 05, 05),
                respuestaPosible = respuesta14
            };

            RespuestaDeCliente respuestaCliente11 = new RespuestaDeCliente
            {
                id = 11,
                fechaEncuesta = new DateTime(2023, 05, 05),
                respuestaPosible = respuesta12
            };

            RespuestaDeCliente respuestaCliente12 = new RespuestaDeCliente
            {
                id = 12,
                fechaEncuesta = new DateTime(2023, 05, 05),
                respuestaPosible = respuesta13
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
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado1, cambioEstado14 },
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente2, respuestaCliente3, respuestaCliente5 }
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
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente1, respuestaCliente4, respuestaCliente6 }
            };

            Llamada llamada3 = new Llamada
            {
                id = 3,
                descripcionOperador = 2,
                detalleAccionRequerida = 1,
                duracion = 15,
                encuestaEnviada = 2,
                observacionAuditor = 1,
                cliente = cliente3,
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado4, cambioEstado5, cambioEstado6, cambioEstado7 },
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente7, respuestaCliente8 }
            };

            Llamada llamada4 = new Llamada
            {
                id = 4,
                descripcionOperador = 2,
                detalleAccionRequerida = 1,
                duracion = 25,
                encuestaEnviada = 2,
                observacionAuditor = 1,
                cliente = cliente4,
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado8, cambioEstado9, cambioEstado10, cambioEstado11 },
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente9, respuestaCliente10 }
            };

            Llamada llamada5 = new Llamada
            {
                id = 5,
                descripcionOperador = 2,
                detalleAccionRequerida = 1,
                duracion = 43,
                encuestaEnviada = 2,
                observacionAuditor = 1,
                cliente = cliente5,
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado12, cambioEstado13 },
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente11, respuestaCliente12 }
            };

            List<Llamada> llamadas = new List<Llamada> { llamada1, llamada2, llamada3, llamada4, llamada5 };
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
                nombreCompleto = "Gustavo Adrian Cerati",
                numeroCelular = 3511234567,
            };

            Cliente cliente2 = new Cliente
            {
                dni = 42897654,
                nombreCompleto = "Carlos Alberto Garcia",
                numeroCelular = 3512012012,
            };

            Cliente cliente3 = new Cliente
            {
                dni = 35897635,
                nombreCompleto = "Federico Moura",
                numeroCelular = 3519122018,
            };

            Cliente cliente4 = new Cliente
            {
                dni = 36380465,
                nombreCompleto = "Cristian Gabriel Alvarez",
                numeroCelular = 3516380465,
            };

            Cliente cliente5 = new Cliente
            {
                dni = 20020020,
                nombreCompleto = "Patricio Santos Fontanet",
                numeroCelular = 3040274720,
            };

            //Estados
            Estado inicial = new Estado
            {
                nombre = "Inicial"
            };

            Estado reconectando = new Estado
            {
                nombre = "Reconectando"
            };

            Estado reconectado = new Estado
            {
                nombre = "Reconectado"
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
                fechaHoraFin = new DateTime(2023, 04, 04, 10, 25, 00),
                estado = inicial,
            };

            CambioDeEstado cambioEstado14 = new CambioDeEstado
            {
                id = 3,
                fechaHoraInicio = new DateTime(2023, 04, 04, 10, 25, 00),
                fechaHoraFin = null,
                estado = finalizado,
            };

            CambioDeEstado cambioEstado2 = new CambioDeEstado
            {
                id = 2,
                fechaHoraInicio = new DateTime(2023, 05, 01, 10, 20, 00),
                fechaHoraFin = new DateTime(2023, 05, 03, 10, 20, 30),
                estado = inicial,
            };

            CambioDeEstado cambioEstado3 = new CambioDeEstado
            {
                id = 3,
                fechaHoraInicio = new DateTime(2023, 05, 04, 10, 20, 00),
                fechaHoraFin = null,
                estado = finalizado,
            };

            CambioDeEstado cambioEstado4 = new CambioDeEstado
            {
                id = 4,
                fechaHoraInicio = new DateTime(2023, 04, 04, 10, 20, 00),
                fechaHoraFin = new DateTime(2023, 04, 04, 10, 22, 00),
                estado = inicial,
            };

            CambioDeEstado cambioEstado5 = new CambioDeEstado
            {
                id = 5,
                fechaHoraInicio = new DateTime(2023, 05, 04, 10, 22, 00),
                fechaHoraFin = new DateTime(2023, 05, 04, 10, 23, 00),
                estado = reconectando,
            };

            CambioDeEstado cambioEstado6 = new CambioDeEstado
            {
                id = 6,
                fechaHoraInicio = new DateTime(2023, 05, 04, 10, 23, 00),
                fechaHoraFin = new DateTime(2023, 05, 04, 10, 29, 00),
                estado = reconectado,
            };

            CambioDeEstado cambioEstado7 = new CambioDeEstado
            {
                id = 7,
                fechaHoraInicio = new DateTime(2023, 05, 04, 10, 29, 00),
                fechaHoraFin = null,
                estado = finalizado,
            };

            CambioDeEstado cambioEstado8 = new CambioDeEstado
            {
                id = 8,
                fechaHoraInicio = new DateTime(2023, 05, 04, 10, 20, 00),
                fechaHoraFin = new DateTime(2023, 05, 04, 10, 22, 00),
                estado = inicial,
            };

            CambioDeEstado cambioEstado9 = new CambioDeEstado
            {
                id = 9,
                fechaHoraInicio = new DateTime(2023, 05, 04, 10, 22, 00),
                fechaHoraFin = new DateTime(2023, 05, 04, 10, 23, 00),
                estado = reconectando,
            };

            CambioDeEstado cambioEstado10 = new CambioDeEstado
            {
                id = 10,
                fechaHoraInicio = new DateTime(2023, 05, 04, 10, 23, 00),
                fechaHoraFin = new DateTime(2023, 05, 04, 10, 29, 00),
                estado = reconectado,
            };

            CambioDeEstado cambioEstado11 = new CambioDeEstado
            {
                id = 1,
                fechaHoraInicio = new DateTime(2023, 05, 04, 10, 29, 00),
                fechaHoraFin = null,
                estado = finalizado,
            };

            CambioDeEstado cambioEstado12 = new CambioDeEstado
            {
                id = 12,
                fechaHoraInicio = new DateTime(2023, 05, 03, 10, 20, 00),
                fechaHoraFin = new DateTime(2023, 05, 03, 10, 20, 30),
                estado = inicial,
            };

            CambioDeEstado cambioEstado13 = new CambioDeEstado
            {
                id = 13,
                fechaHoraInicio = new DateTime(2023, 05, 04, 10, 20, 00),
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
                valor = "4",
                descripcion = "Regular"
            };

            RespuestaPosible respuesta5 = new RespuestaPosible
            {
                valor = "5",
                descripcion = "Bueno"
            };

            RespuestaPosible respuesta6 = new RespuestaPosible
            {
                valor = "6",
                descripcion = "1 a 3"
            };

            RespuestaPosible respuesta7 = new RespuestaPosible
            {
                valor = "7",
                descripcion = "3 o más"
            };

            RespuestaPosible respuesta8 = new RespuestaPosible
            {
                valor = "8",
                descripcion = "1"
            };

            RespuestaPosible respuesta9 = new RespuestaPosible
            {
                valor = "9",
                descripcion = "2"
            };

            RespuestaPosible respuesta10 = new RespuestaPosible
            {
                valor = "10",
                descripcion = "3"
            };

            RespuestaPosible respuesta11 = new RespuestaPosible
            {
                valor = "11",
                descripcion = "4"
            };

            RespuestaPosible respuesta12 = new RespuestaPosible
            {
                valor = "12",
                descripcion = "5"
            };

            RespuestaPosible respuesta13 = new RespuestaPosible
            {
                valor = "13",
                descripcion = "si"
            };
            RespuestaPosible respuesta14 = new RespuestaPosible
            {
                valor = "14",
                descripcion = "no"
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


            Pregunta pregunta3 = new Pregunta
            {
                valor = 3,
                pregunta = "¿Cuantas veces al mes solicita nuestra ayuda?",
                respuesta = new List<RespuestaPosible> { respuesta6, respuesta7 }
            };

            Pregunta pregunta4 = new Pregunta
            {
                valor = 4,
                pregunta = "Puntue del 1 al 5 la calidad de la llamada",
                respuesta = new List<RespuestaPosible> { respuesta8, respuesta9, respuesta10, respuesta11, respuesta12 }
            };

            Pregunta pregunta5 = new Pregunta
            {
                valor = 5,
                pregunta = "¿Se perdio la conexion de la llamada en algun momento?",
                respuesta = new List<RespuestaPosible> { respuesta13, respuesta14 }
            };

            //Encuesta
            Encuesta encuestaSatisfaccion = new Encuesta
            {
                id = 1,
                descripcion = "Encuesta de satisfacción",
                fechaFinVigencia = new DateTime(2024, 04, 04, 10, 20, 00),
                preguntas = new List<Pregunta> { pregunta1, pregunta2, pregunta3 }
            };

            Encuesta encuestaCalidadLlamada = new Encuesta
            {
                id = 2,
                descripcion = "Encuesta de calidad de llamada",
                fechaFinVigencia = new DateTime(2024, 03, 03, 00, 00, 00),
                preguntas = new List<Pregunta> { pregunta4, pregunta5 }
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

            RespuestaDeCliente respuestaCliente5 = new RespuestaDeCliente
            {
                id = 5,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta7
            };

            RespuestaDeCliente respuestaCliente6 = new RespuestaDeCliente
            {
                id = 6,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta6
            };

            RespuestaDeCliente respuestaCliente7 = new RespuestaDeCliente
            {
                id = 7,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta8
            };

            RespuestaDeCliente respuestaCliente8 = new RespuestaDeCliente
            {
                id = 8,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta14
            };

            RespuestaDeCliente respuestaCliente9 = new RespuestaDeCliente
            {
                id = 9,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta10
            };

            RespuestaDeCliente respuestaCliente10 = new RespuestaDeCliente
            {
                id = 10,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta14
            };

            RespuestaDeCliente respuestaCliente11 = new RespuestaDeCliente
            {
                id = 11,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta12
            };

            RespuestaDeCliente respuestaCliente12 = new RespuestaDeCliente
            {
                id = 12,
                fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
                respuestaPosible = respuesta13
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
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado1, cambioEstado14 },
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente2, respuestaCliente3, respuestaCliente5 }
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
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente1, respuestaCliente4, respuestaCliente6 }
            };

            Llamada llamada3 = new Llamada
            {
                id = 3,
                descripcionOperador = 2,
                detalleAccionRequerida = 1,
                duracion = 15,
                encuestaEnviada = 2,
                observacionAuditor = 1,
                cliente = cliente3,
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado4, cambioEstado5, cambioEstado6, cambioEstado7 },
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente7, respuestaCliente8 }
            };

            Llamada llamada4 = new Llamada
            {
                id = 4,
                descripcionOperador = 2,
                detalleAccionRequerida = 1,
                duracion = 25,
                encuestaEnviada = 2,
                observacionAuditor = 1,
                cliente = cliente4,
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado8, cambioEstado9, cambioEstado10, cambioEstado11 },
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente9, respuestaCliente10 }
            };

            Llamada llamada5 = new Llamada
            {
                id = 5,
                descripcionOperador = 2,
                detalleAccionRequerida = 1,
                duracion = 43,
                encuestaEnviada = 2,
                observacionAuditor = 1,
                cliente = cliente5,
                cambioDeEstado = new List<CambioDeEstado?> { cambioEstado12, cambioEstado13 },
                respuestaDeCliente = new List<RespuestaDeCliente> { respuestaCliente11, respuestaCliente12 }
            };

            List<Llamada> llamadas = new List<Llamada> { llamada1, llamada2, llamada3, llamada4, llamada5 };
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
        public bool tomarOpcionDeImpresion(LlamadaSeleccionada llamadaSelec)
        {
            return generarCSV(llamadaSelec);
            bool generarCSV(LlamadaSeleccionada llamadaSeleccionada)
            {
                string csv = llamadaSeleccionada.nombre.ToString() + "," + llamadaSeleccionada.estado.ToString() + "," + llamadaSeleccionada.duracion.ToString();
                foreach (var pregunta in llamadaSeleccionada.preguntaRespuestas)
                {
                    string pregRes = "\n►" + pregunta.pregunta + "," + pregunta.respuesta + "◄";
                    csv = string.Concat(csv, pregRes);
                }
                var llamarMetodo = new LlamadaSeleccionada();
                llamarMetodo.generarCSV(csv);
                return true;
            };
        }
    }
}
