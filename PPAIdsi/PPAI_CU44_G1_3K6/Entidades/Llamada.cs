using PPAI_CU44_G1_3K6.ViewModel;

namespace PPAI_CU44_G1_3K6.Entidades
{
    public class Llamada
    {
        public int id { get; set; }
        public int descripcionOperador { get; set; }
        public int detalleAccionRequerida { get; set; }
        public int duracion { get; set; }
        public int encuestaEnviada { get; set; }
        public int observacionAuditor { get; set; }
        public Cliente? cliente { get; set; }
        public List<CambioDeEstado?> cambioDeEstado { get; set; }
        public List<RespuestaDeCliente?> respuestaDeCliente { get; set; }

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

        public LlamadaSeleccionada getDatosLlamada()
        {
            string nombreCompleto = getNombreClienteDeLaLlamada(this.cliente);
            string estadoActual = "";
            foreach(var cambioEstado in this.cambioDeEstado)
            {
                string estado = cambioEstado.esUltimoEstado();
                if (!(estado.Equals(string.Empty)))
                {
                    estadoActual = estado;
                    break;
                }
            }
            string duracion = getDuracion();
            LlamadaSeleccionada llamadaSeleccionada = new LlamadaSeleccionada
            {
                nombre = nombreCompleto,
                estado = estadoActual,
                duracion = duracion
            };
            return llamadaSeleccionada;
        }

        private string getDuracion()
        {
            var tiempo = TimeSpan.FromMinutes(this.duracion);
            return tiempo.ToString();
            //return tiempo.ToString("hh:mm:ss");
        }

        private string getNombreClienteDeLaLlamada(Cliente clienteLlamada)
        {
            return clienteLlamada.getNombre();
        }
        
        public List<string> obtenerRespuestas(List<List<RespuestaPosible>> lista)
        {
            var respuestasCliente = new List<string>();
            foreach (var respuestasPosible in lista)
            {
                foreach (var respuesta in respuestasPosible)
                {
                    foreach(var respuestaCliente in this.respuestaDeCliente)
                    {
                        if (respuestaCliente.getDescripcionRespuesta().Equals(respuesta.descripcion))
                        {
                            respuestasCliente.Add(respuesta.descripcion);
                        }

                    }
                }
            }
            return respuestasCliente;
        }
    }
}
