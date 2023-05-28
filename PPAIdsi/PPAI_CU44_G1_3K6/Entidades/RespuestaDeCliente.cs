namespace PPAI_CU44_G1_3K6.Entidades
{
    public class RespuestaDeCliente
    {
        public int id { get; set; }
        public DateTime fechaEncuesta { get; set; }
        public RespuestaPosible respuestaPosible { get; set; }
        
        public string getDescripcionRespuesta()
        {
            return this.respuestaPosible.getDescripcionRespuesta();
        }
    }
}
