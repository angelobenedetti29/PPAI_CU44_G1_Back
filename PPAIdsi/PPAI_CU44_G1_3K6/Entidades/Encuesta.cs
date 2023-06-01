namespace PPAI_CU44_G1_3K6.Entidades
{
    public class Encuesta
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaFinVigencia { get; set; }
        public List<Pregunta> preguntas { get; set; }

        #region objetos
        //RespuestaPosible
        static RespuestaPosible respuesta1 = new RespuestaPosible
        {
            valor = "1",
            descripcion = "Si"
        };
        static RespuestaPosible respuesta2 = new RespuestaPosible
        {
            valor = "2",
            descripcion = "No"
        };

        static RespuestaPosible respuesta3 = new RespuestaPosible
        {
            valor = "3",
            descripcion = "Malo"
        };

        static RespuestaPosible respuesta4 = new RespuestaPosible
        {
            valor = "4",
            descripcion = "Regular"
        };

        static RespuestaPosible respuesta5 = new RespuestaPosible
        {
            valor = "5",
            descripcion = "Bueno"
        };

        static RespuestaPosible respuesta6 = new RespuestaPosible
        {
            valor = "6",
            descripcion = "1 a 3"
        };

        static RespuestaPosible respuesta7 = new RespuestaPosible
        {
            valor = "7",
            descripcion = "3 o más"
        };

        static RespuestaPosible respuesta8 = new RespuestaPosible
        {
            valor = "8",
            descripcion = "1"
        };

        static RespuestaPosible respuesta9 = new RespuestaPosible
        {
            valor = "9",
            descripcion = "2"
        };

        static RespuestaPosible respuesta10 = new RespuestaPosible
        {
            valor = "10",
            descripcion = "3"
        };

        static RespuestaPosible respuesta11 = new RespuestaPosible
        {
            valor = "11",
            descripcion = "4"
        };

        static RespuestaPosible respuesta12 = new RespuestaPosible
        {
            valor = "12",
            descripcion = "5"
        };

        static RespuestaPosible respuesta13 = new RespuestaPosible
        {
            valor = "13",
            descripcion = "si"
        };
        static RespuestaPosible respuesta14 = new RespuestaPosible
        {
            valor = "14",
            descripcion = "no"
        };

        //Pregunta
        static Pregunta pregunta1 = new Pregunta
        {
            valor = 1,
            pregunta = "¿Solucionamos su consulta?",
            respuesta = new List<RespuestaPosible> { respuesta1, respuesta2 }
        };

        static Pregunta pregunta2 = new Pregunta
        {
            valor = 2,
            pregunta = "Describa el servicio",
            respuesta = new List<RespuestaPosible> { respuesta3, respuesta4, respuesta5 }
        };


        static Pregunta pregunta3 = new Pregunta
        {
            valor = 3,
            pregunta = "¿Cuantas veces al mes solicita nuestra ayuda?",
            respuesta = new List<RespuestaPosible> { respuesta6, respuesta7 }
        };

        static Pregunta pregunta4 = new Pregunta
        {
            valor = 4,
            pregunta = "Puntue del 1 al 5 la calidad de la llamada",
            respuesta = new List<RespuestaPosible> { respuesta8, respuesta9, respuesta10, respuesta11, respuesta12 }
        };

        static Pregunta pregunta5 = new Pregunta
        {
            valor = 5,
            pregunta = "¿Se perdio la conexion de la llamada en algun momento?",
            respuesta = new List<RespuestaPosible> { respuesta13, respuesta14 }
        };

        //Encuesta
        static Encuesta encuestaSatisfaccion = new Encuesta
        {
            id = 1,
            descripcion = "Encuesta de satisfacción",
            fechaFinVigencia = new DateTime(2024, 04, 04),
            preguntas = new List<Pregunta> { pregunta1, pregunta2, pregunta3 }
        };

        static Encuesta encuestaCalidadLlamada = new Encuesta
        {
            id = 2,
            descripcion = "Encuesta de calidad de llamada",
            fechaFinVigencia = new DateTime(2024, 03, 03),
            preguntas = new List<Pregunta> { pregunta4, pregunta5 }
        };

        //RespuestaDeCliente
        static RespuestaDeCliente respuestaCliente1 = new RespuestaDeCliente
        {
            id = 1,
            fechaEncuesta = new DateTime(2023, 05, 05),
            respuestaPosible = respuesta1
        };

        static RespuestaDeCliente respuestaCliente2 = new RespuestaDeCliente
        {
            id = 2,
            fechaEncuesta = new DateTime(2023, 05, 05),
            respuestaPosible = respuesta2
        };

        static RespuestaDeCliente respuestaCliente3 = new RespuestaDeCliente
        {
            id = 3,
            fechaEncuesta = new DateTime(2023, 05, 05),
            respuestaPosible = respuesta4
        };

        static RespuestaDeCliente respuestaCliente4 = new RespuestaDeCliente
        {
            id = 4,
            fechaEncuesta = new DateTime(2023, 05, 05),
            respuestaPosible = respuesta5
        };

        static RespuestaDeCliente respuestaCliente5 = new RespuestaDeCliente
        {
            id = 5,
            fechaEncuesta = new DateTime(2023, 05, 05),
            respuestaPosible = respuesta7
        };

        static RespuestaDeCliente respuestaCliente6 = new RespuestaDeCliente
        {
            id = 6,
            fechaEncuesta = new DateTime(2023, 05, 05),
            respuestaPosible = respuesta6
        };

        static RespuestaDeCliente respuestaCliente7 = new RespuestaDeCliente
        {
            id = 7,
            fechaEncuesta = new DateTime(2023, 05, 05),
            respuestaPosible = respuesta8
        };

        static RespuestaDeCliente respuestaCliente8 = new RespuestaDeCliente
        {
            id = 8,
            fechaEncuesta = new DateTime(2023, 05, 05),
            respuestaPosible = respuesta14
        };

        static RespuestaDeCliente respuestaCliente9 = new RespuestaDeCliente
        {
            id = 9,
            fechaEncuesta = new DateTime(2023, 05, 05),
            respuestaPosible = respuesta10
        };

        static RespuestaDeCliente respuestaCliente10 = new RespuestaDeCliente
        {
            id = 10,
            fechaEncuesta = new DateTime(2023, 05, 05),
            respuestaPosible = respuesta14
        };

        static RespuestaDeCliente respuestaCliente11 = new RespuestaDeCliente
        {
            id = 11,
            fechaEncuesta = new DateTime(2023, 05, 05),
            respuestaPosible = respuesta12
        };

        static RespuestaDeCliente respuestaCliente12 = new RespuestaDeCliente
        {
            id = 12,
            fechaEncuesta = new DateTime(2023, 05, 05),
            respuestaPosible = respuesta13
        };

        List<Encuesta> encuestas = new List<Encuesta> { encuestaSatisfaccion, encuestaCalidadLlamada };
        #endregion
        public (Encuesta, List<Pregunta>, List<List<RespuestaPosible>>) esEncuestaDeCliente(int idEncuesta)
        {
            Encuesta encuestaLlamada = new Encuesta();
            List<Pregunta> preguntas = new List<Pregunta>();
            List<List<RespuestaPosible>> respuestas = new List<List<RespuestaPosible>>();
            foreach(var encuesta in encuestas)
            {
                if(encuesta.id == idEncuesta)
                {
                    encuestaLlamada = encuesta;
                    foreach(var pregunta in encuesta.preguntas)
                    {
                        preguntas.Add(pregunta);
                        respuestas.Add(pregunta.listarRespuestasPosibles());
                    };
                }
            }
            return (encuestaLlamada, preguntas, respuestas);
        }
        public string getDescipcion()
        {
            return this.descripcion;
        }
        public List<string> obtenerDescripcionPregunta(List<Pregunta> preguntas)
        {
            List<string> descripcionPreguntas = new List<string>();
            foreach(var pregunta in preguntas)
            {
                descripcionPreguntas.Add(pregunta.getDescripcion());
            }
            return descripcionPreguntas;
        }

    }
}
