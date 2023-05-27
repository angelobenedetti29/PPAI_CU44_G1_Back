namespace PPAI_CU44_G1_3K6.Entidades
{
    public class Encuesta
    {
        public string descripcion { get; set; }
        public DateTime fechaFinVigencia { get; set; }
        public List<Pregunta> preguntas { get; set; }

    }
}
