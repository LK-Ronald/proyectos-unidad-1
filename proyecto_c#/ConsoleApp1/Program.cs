namespace ConsoleApp1
{

    class Program
    {
        static void Main()
        {

            Estudiante[] estudiantes = [
                new Estudiante("Ronald", 12, 3.3),
                new Estudiante("Camilo", 22, 4.4),
                new Estudiante("Jose", 18, 2.9),
                new Estudiante("Andres", 55, 2.2),
           ];

            foreach (var e in estudiantes)
            {
                Console.WriteLine(e);
            }

        }
    }


    record Estudiante
    {
        public string Nombre { get; init; }
        public int Edad { get; init; }
        public double Promedio { get; init; }

        public Estudiante(string nombre, int edad, double promedio)
        {
            Nombre = nombre;
            Edad = edad;
            Promedio = promedio;
        }
    }
}