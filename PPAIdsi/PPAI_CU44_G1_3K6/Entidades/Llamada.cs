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
        public List<CambioDeEstado?> cambioDeEstado { get; set; }
        public RespuestaDeCliente? respuestaDeCliente { get; set; }

        public bool tieneEncRespondidas(DateTime fechaInicio, DateTime fechaFin)
        {
            foreach (var cambioDeEstado in this.cambioDeEstado)
            {
                if(cambioDeEstado.esEstadoInicial())
                {
                    var fechaHoraInicioEstado = cambioDeEstado.getFechaHoraInicio();
                    if (DateTime.Compare(fechaHoraInicioEstado, fechaInicio) > 0 && DateTime.Compare(fechaHoraInicioEstado, fechaFin) < 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
