internal class Program
{
    private static void Main(string[] args)
    {
        // Crear una lista de objetos Persona
        List<Persona> personas = new List<Persona>
        {
            new Persona { Nombre = "Juan", Edad = 30 },
            new Persona { Nombre = "María", Edad = 25 },
            new Persona { Nombre = "Pedro", Edad = 35 },
            new Persona { Nombre = "Ana", Edad = 28 },
            new Persona { Nombre = "Luis", Edad = 40 }
        };

        // Consulta utilizando LINQ para obtener personas mayores de 30 años
        var personasMayores = from persona in personas
                              where persona.Edad > 30
                              select persona;

        // Mostrar los resultados
        Console.WriteLine("Personas mayores de 30 años:");
        foreach (var persona in personasMayores)
        {
            Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
        }

        // Otra forma de realizar la misma consulta utilizando métodos de extensión de LINQ
        var personasMenores = personas.Where(persona => persona.Edad < 30);

        // Mostrar los resultados
        Console.WriteLine("\nPersonas menores de 30 años:");
        foreach (var persona in personasMenores)
        {
            Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
        }
    }
}

class Persona
{
    public string ? Nombre { get; set; }
    public int Edad { get; set; }
}