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
        private int id;
        private string titulo;
        private string descripcion;
        private estados estado;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public estados Estado { get => estado; set => estado = value; }

        public Tarea(int id, string titulo, string descripcion, estados estado)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Estado = estado;
        }
    }
}