namespace TP7
{
    using System.Text.Json;
    public class AccesoADatosTareaJSON
    {
        public List<Tarea> ListaTareas = new List<Tarea>();


        public List<Tarea> LeerTarea()
        {
            string archivo = File.ReadAllText("models/tareas.json");
            ListaTareas = JsonSerializer.Deserialize<List<Tarea>>(archivo);
            return ListaTareas;
        }

        public bool guardar(List<Tarea> Tareas)
        {
            if (Tareas != null)
            {
                string archivo = JsonSerializer.Serialize(Tareas);
                File.WriteAllText("models/tareas.json", archivo);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}