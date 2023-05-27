namespace PPAI_CU44_G1_3K6.Entidades
{
    public class Llamada
    {
        public int descripcionOperador { get; set; }
        public int detalleAccionRequerida { get; set; }
        public int duracion { get; set; }
        public int encuestaEnviada { get; set; }
        public int observacionAuditor { get; set; }
        public Cliente? cliente { get; set; }
        public CambioDeEstado? cambioDeEstado { get; set; }
        public RespuestaDeCliente? respuestaDeCliente { get; set; }


    }
}
