namespace TP7
{

    public enum estados
    {
        Pendiente = 0,
        EnProgreso = 1,
        Completada = 2
    }
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public estados Estado { get; set; }

        private static Tarea instance;

        public static Tarea Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Tarea("La Septima", "Boooocaaaaaa");
                }
                return instance;
            }
        }

        public Tarea()
        {

        }

        public Tarea(string titulo, string descripcion)
        {
            this.Id = 0;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Estado = 0;
        }
    }
}