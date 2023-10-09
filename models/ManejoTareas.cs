namespace TP7
{
    public class ManejoTareas
    {
        public AccesoADatosTareaJSON acceso;
        public List<Tarea> ListaTareas;

        public ManejoTareas()
        {
            this.acceso = new AccesoADatosTareaJSON();
            ListaTareas = this.acceso.LeerTarea();
        }

        public bool crearNuevaTarea(Tarea t)
        {
            ListaTareas.Add(t);

            if (acceso.guardar(ListaTareas))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Tarea TareaPorId(int id)
        {
            Tarea t = ListaTareas.FirstOrDefault(t => t.Id == id);
            if (t != null)
            {
                return t;
            }
            return null;
        }

        public bool ActualizarTarea(Tarea t)
        {
            Tarea TareaEncontrada = ListaTareas.FirstOrDefault(item => item.Id == t.Id);
            TareaEncontrada.Titulo = t.Titulo;
            TareaEncontrada.Descripcion = t.Descripcion;
            TareaEncontrada.Estado = t.Estado;

            return this.acceso.guardar(ListaTareas);

        }

        public bool EliminarTarea(int id)
        {
            Tarea t = ListaTareas.FirstOrDefault(t => t.Id == id);

            if (t != null)
            {
                ListaTareas.Remove(t);
                return acceso.guardar(ListaTareas);
            }
            else
            {
                return false;
            }
        }

        public List<Tarea> ListarTareas()
        {
            return this.ListaTareas;
        }

        public List<Tarea> ListarTareasCompletadas()
        {
            List<Tarea> TareasCompletadas = new List<Tarea>();
            TareasCompletadas = ListaTareas.FindAll(t => t.Estado == estados.Completada);

            return TareasCompletadas;
        }
    }
}