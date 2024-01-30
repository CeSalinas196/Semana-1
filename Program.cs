
class Program
{
    static void Main()
    {
        // Crear objetos SuperPoder
        SuperPoder superFuerza = new SuperPoder
        {
            Nombre = "Super fuerza",
            Descripcion = "Capacidad de levantar objetos muy pesados",
            Nivel = 9
        };

        // Crear objetos SuperHeroe
        SuperHeroe superman = new SuperHeroe
        {
            Nombre = "Superman",
            IdentidadSecreta = "Clark Kent",
            Ciudad = "Metrópolis",
            PuedeVolar = true,
            SuperPoder = superFuerza
        };

        // Mostrar la información del SuperHeroe
        superman.MostrarInformacion();

        // Datos de SuperHeroes
        SuperHeroe batman = new SuperHeroe
        {
            Nombre = "Batman",
            IdentidadSecreta = "Bruce Wayne",
            Ciudad = "Gotham",
            PuedeVolar = false,
            SuperPoder = new SuperPoder
            {
                Nombre = "Inteligencia",
                Descripcion = "Mente brillante y habilidades deductivas",
                Nivel = 8
            }
        };

        SuperHeroe mujerMaravilla = new SuperHeroe
        {
            Nombre = "Mujer Maravilla",
            IdentidadSecreta = "Diana Prince",
            Ciudad = "Themyscira",
            PuedeVolar = true,
            SuperPoder = new SuperPoder
            {
                Nombre = "Lazo de la Verdad",
                Descripcion = "Fuerza sobrehumana y habilidad para la verdad",
                Nivel = 7
            }
        };

        SuperHeroe flash = new SuperHeroe
        {
            Nombre = "Flash",
            IdentidadSecreta = "Barry Allen",
            Ciudad = "Central City",
            PuedeVolar = false,
            SuperPoder = new SuperPoder
            {
                Nombre = "Velocidad",
                Descripcion = "Capacidad de correr a velocidades sobrehumanas",
                Nivel = 10
            }
        };

        SuperHeroe linternaVerde = new SuperHeroe
        {
            Nombre = "Linterna Verde",
            IdentidadSecreta = "Hal Jordan",
            Ciudad = "Coast City",
            PuedeVolar = true,
            SuperPoder = new SuperPoder
            {
                Nombre = "Anillo de Poder",
                Descripcion = "Creación de construcciones sólidas con el anillo",
                Nivel = 8
            }
        };

        SuperHeroe spiderman = new SuperHeroe
        {
            Nombre = "Spiderman",
            IdentidadSecreta = "Peter Parker",
            Ciudad = "Nueva York",
            PuedeVolar = false,
            SuperPoder = new SuperPoder
            {
                Nombre = "Agilidad y Sentido Arácnido",
                Descripcion = "Reflejos sobrehumanos y sentido arácnido",
                Nivel = 7
            }
        };

        // Mostrar la información de los SuperHeroes
        batman.MostrarInformacion();
        mujerMaravilla.MostrarInformacion();
        flash.MostrarInformacion();
        linternaVerde.MostrarInformacion();
        spiderman.MostrarInformacion();

        Console.ReadLine();
    }
}




// SuperPoder.cs
public class SuperPoder
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int Nivel { get; set; }
}

// SuperHeroe.cs
public class SuperHeroe
{
    public string Nombre { get; set; }
    public string IdentidadSecreta { get; set; }
    public string Ciudad { get; set; }
    public bool PuedeVolar { get; set; }
    public SuperPoder SuperPoder { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
        Console.WriteLine($"Ciudad: {Ciudad}");
        Console.WriteLine($"Puede Volar: {PuedeVolar}");
        Console.WriteLine($"Super Poder: {SuperPoder.Nombre}");
        Console.WriteLine($"Descripcion: {SuperPoder.Descripcion}");
        Console.WriteLine($"Nivel: {SuperPoder.Nivel}");
        Console.WriteLine();
    }
}


