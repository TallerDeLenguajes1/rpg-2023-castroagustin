using System;
using System.IO;
using System.Text.Json;
using espacioPersonajes;
using espacioPersonajesJson;

internal class Program
{
    private static void Main(string[] args)
    {

        var Personajes = new List<Personaje>();
        List<Personaje> ganadores = new List<Personaje>();
        var PersonajesJson = new PersonajesJson();
        Random random = new Random();

        if (PersonajesJson.Existe("personajes.json"))
        {
            Personajes = PersonajesJson.LeerPersonajes("personajes.json");
        }
        else
        {
            // Crear 10 pj
        }

        Console.WriteLine("---------- COMIENZA EL JUEGO ----------");
    }
}