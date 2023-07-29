namespace espacioPersonajes
{
    public class FabricaDePersonajes
    {

        string[] tipo = { "Mago", "Dragon", "Barbaro", "Gigante", "Arquero", "Duende", "Caballero" };
        string[] nombre = { "Juan", "Pedro", "Diego", "Carlos", "Agustin", "Matias" };

        Random random = new Random();

        public Personaje crearPersonaje()
        {
            int anio = random.Next(1900, 2024);
            int mes = random.Next(1, 13);
            int dia = random.Next(1, DateTime.DaysInMonth(anio, mes) + 1);
            DateTime hoy = DateTime.Today;
            Personaje nuevoPersonaje = new();

            nuevoPersonaje.Tipo = tipo[random.Next(0, 6)];
            nuevoPersonaje.Nombre = tipo[random.Next(0, 5)];
            nuevoPersonaje.Armadura = random.Next(1, 11);
            nuevoPersonaje.Fuerza = random.Next(1, 11);
            nuevoPersonaje.Destreza = random.Next(1, 6);
            nuevoPersonaje.Nivel = random.Next(1, 11);
            nuevoPersonaje.Velocidad = random.Next(1, 11);
            nuevoPersonaje.FecNac = new DateTime(anio, mes, dia);
            nuevoPersonaje.Edad = DateTime.Today.Subtract(nuevoPersonaje.FecNac).Days / 365;
            nuevoPersonaje.Salud = 100;

            return nuevoPersonaje;
        }
    }
}