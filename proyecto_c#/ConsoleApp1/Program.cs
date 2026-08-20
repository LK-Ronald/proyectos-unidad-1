namespace ConsoleApp1
{

    class Program
    {
        static void Main()
        {

           

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