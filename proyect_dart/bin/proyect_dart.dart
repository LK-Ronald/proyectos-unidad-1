void main() {
  List<({String nombre, int edad, double promedio})> estudiantes = [
    (nombre: "Camilo", edad: 15, promedio: 2.8),
    (nombre: "Jose", edad: 22, promedio: 3.2),
    (nombre: "Ronald", edad: 34, promedio: 4.5),
  ];

  for (var e in estudiantes) {
    print(e);
  }
}
