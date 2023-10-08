namespace TP7
{
    using System.Text.Json;
    public class AccesoADatosTareaJSON
    {
        public string ruta = "tareas.json";

        public List<Tarea> LeerTarea()
        {
            string archivo = File.ReadAllText(ruta);
            List<Tarea> Tareas = JsonSerializer.Deserialize<List<Tarea>>(archivo);
            return Tareas;
        }

        public bool guardar(List<Tarea> Tareas)
        {
            if (Tareas != null)
            {
                string archivo = JsonSerializer.Serialize(Tareas);
                File.WriteAllText(ruta, archivo);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}