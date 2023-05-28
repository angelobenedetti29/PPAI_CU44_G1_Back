namespace PPAI_CU44_G1_3K6.Entidades
{
    public class Pregunta
    {
        public int valor { get; set; }
        public string pregunta { get; set; }
        public List<RespuestaPosible> respuesta { get; set; }

        public List<RespuestaPosible> listarRespuestasPosibles()
        {
            List<RespuestaPosible> respuestasPregunta = new List<RespuestaPosible>();
            foreach (var res in this.respuesta)
            {
                respuestasPregunta.Add(res);
            }
            return respuestasPregunta;
        }
        
        public string getDescripcion() 
        {
            return this.pregunta;
        }
    }
}
