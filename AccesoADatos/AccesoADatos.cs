namespace TP7
{
    using System.Text.Json;
    public class AccesoADatosTareaJSON
    {
        public List<Tarea> LeerTarea()
        {
            string archivo = File.ReadAllText("models/tareas.json");
            List<Tarea> Tareas = JsonSerializer.Deserialize<List<Tarea>>(archivo);
            return Tareas;
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