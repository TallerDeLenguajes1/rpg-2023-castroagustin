using System.Text.Json;
using espacioPersonajes;

namespace espacioPersonajesJson
{
    public class PersonajesJson
    {
        public void GuardarPersonajes(List<Personaje> Personajes, string archivo)
        {
            string json = JsonSerializer.Serialize(Personajes);
            File.WriteAllText(archivo, json);
        }

        public List<Personaje> LeerPersonajes(string archivo)
        {
            string jsonString = File.ReadAllText(archivo);
            List<Personaje>? Personajes = JsonSerializer.Deserialize<List<Personaje>>(jsonString);

            if (Personajes == null) Personajes = new List<Personaje>();

            return Personajes;
        }

        public bool Existe(string archivo)
        {
            if (File.Exists(archivo))
            {
                string contenido = File.ReadAllText(archivo);
                return !string.IsNullOrEmpty(contenido);
            }
            return false;
        }
    }
}