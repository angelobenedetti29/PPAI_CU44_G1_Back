namespace PPAI_CU44_G1_3K6.Entidades
{
    public class Estado
    {
        public string nombre { get; set; }

        public bool esIniciado()
        {
            return this.nombre.Equals("Inicial");
        }

    }
}
