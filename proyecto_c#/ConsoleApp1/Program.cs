namespace ConsoleApp1
{

    class Program
    {
        static void Main()
        {

            Estudiante[] estudiantes = [
                new Estudiante("Jose", 15, 3.3),
                new Estudiante("Ronald", 21, 5.0),
                new Estudiante("Camilo", 33, 2.9)
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