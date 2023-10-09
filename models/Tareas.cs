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

        public Tarea(int id, string titulo, string descripcion, estados estado)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
    //hemos utilizado propiedades auto-implementadas, lo que significa que el compilador genera automáticamente los campos privados y los métodos de acceso
    //Esto reduce la cantidad de código que debes escribir y hace que la clase sea más legible.
}