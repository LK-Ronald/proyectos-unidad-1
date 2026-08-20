namespace ConsoleApp1
{

    class Program
    {
        static void Main()
        {

            Estudiante[] estudiantes = [
                new Estudiante("Ronald", 15, 5.0),
                new Estudiante("Camilo", 45, 3.5),
                new Estudiante("Jose", 15, 2.0),
            ];

        }
    }


    class Estudiante
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

        public void mostrarInfor()
        {
            Console.WriteLine($"Informacion del estudiante: {Nombre}, {Edad} años, promedio {Promedio} ");
        }
    }
}