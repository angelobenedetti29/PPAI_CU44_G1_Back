namespace PPAI_CU44_G1_3K6.ViewModel
{
    public class LlamadaSeleccionada
    //crear objeto llamadaseleccionada
    //string nombre, string estado, string duracion, string descripcionEncuesta, lista de objetos de abajo

    //creo objeto PreguntaRespuesta y paso lista de esos
    //atributos:
    //string pregunta, string respuesta
    {
        public string nombre { get; set; }
        public string estado { get; set; }
        public string duracion { get; set; }
        public string descripcionEncuesta { get; set; }
        public List<PreguntaRespuesta> preguntaRespuestas { get; set; }
    }
}
