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
            valor = "5",
            descripcion = "Regular"
        };

        static RespuestaPosible respuesta5 = new RespuestaPosible
        {
            valor = "5",
            descripcion = "Bueno"
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

        //Encuesta
        static Encuesta encuestaSatisfaccion = new Encuesta
        {
            id = 1,
            descripcion = "Encuesta de satisfacción",
            fechaFinVigencia = new DateTime(2024, 04, 04, 10, 20, 00),
            preguntas = new List<Pregunta> { pregunta1, pregunta2 }
        };

        //RespuestaDeCliente
        static RespuestaDeCliente respuestaCliente1 = new RespuestaDeCliente
        {
            id = 1,
            fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
            respuestaPosible = respuesta1
        };

        static RespuestaDeCliente respuestaCliente2 = new RespuestaDeCliente
        {
            id = 2,
            fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
            respuestaPosible = respuesta2
        };

        static RespuestaDeCliente respuestaCliente3 = new RespuestaDeCliente
        {
            id = 3,
            fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
            respuestaPosible = respuesta4
        };

        static RespuestaDeCliente respuestaCliente4 = new RespuestaDeCliente
        {
            id = 4,
            fechaEncuesta = new DateTime(2023, 05, 05, 10, 20, 00),
            respuestaPosible = respuesta5
        };
        #endregion

        List<Encuesta> encuestas = new List<Encuesta> { encuestaSatisfaccion };
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
