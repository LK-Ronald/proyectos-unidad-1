namespace ConsoleApp1
{

    class Program
    {
        static void Main()
        {

            EstudianteClase[] estudianteClases = [
                new EstudianteClase("Ronald", 25, 1.3),
                new EstudianteClase("Jose", 54, 2.5),
                new EstudianteClase("Camilo", 34, 3.3)
            ];

            foreach (var e in estudianteClases)
            {
                e.mostrarInfor();
            }

            EstudiantStruct[] estudiantStructs = [
                new EstudiantStruct("Jony", 25, 1.3),
                new EstudiantStruct("Perez", 54, 2.5),
                new EstudiantStruct("Pablo", 34, 3.3)
            ];

            foreach (var e in estudiantStructs)
            {
                e.mostrarInfor();
            }

            EstudiantRecord[] estudiantRecords = [
                new EstudiantRecord("GOzales", 54, 3.3),
                new EstudiantRecord("Pedro", 54, 3.6),
                new EstudiantRecord("Gabriel", 23, 4.4),
            ];

            foreach (var e in estudiantRecords)
            {
                Console.WriteLine(e);
            }

        }
    }


    class EstudianteClase
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Promedio { get; set; }

        public EstudianteClase(string nombre, int edad, double promedio)
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

    struct EstudiantStruct
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Promedio { get; set; }

        public EstudiantStruct(string nombre, int edad, double promedio)
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

    record EstudiantRecord(string nombre, int edad, double promedio);
}