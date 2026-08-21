void main() {
  List<({String nombre, int edad, double promedio})> estudiantes = [
    (nombre: 'Ronald', edad: 15, promedio: 5.0),
    (nombre: 'Camilo', edad: 33, promedio: 4.3),
    (nombre: 'Andres', edad: 55, promedio: 3.5),
    (nombre: 'Jose', edad: 22, promedio: 1.3),
  ];

  for (var e in estudiantes) {
    print(e);
  }
}
