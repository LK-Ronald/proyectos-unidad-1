void main() {
  List<EstudianteClase> estudiantesClase = [
    EstudianteClase(nombre: 'Ronald', edad: 15, promedio: 5.0),
    EstudianteClase(nombre: 'Camilo', edad: 45, promedio: 3.5),
    EstudianteClase(nombre: 'Jose', edad: 15, promedio: 2.0),
  ];

  for (var e in estudiantesClase) {
    e.mostrarInfo();
  }

  List<({String nombre, int edad, double promedio})> estudianteRecord = [
    (nombre: 'Gabriel', edad: 12, promedio: 3.3),
    (nombre: 'Andres', edad: 23, promedio: 3.3),
    (nombre: 'Stiven', edad: 43, promedio: 1.3),
  ];

  for (var e in estudianteRecord) {
    print(e);
  }
}

class EstudianteClase {
  String _nombre;
  int _edad;
  double _promedio;

  EstudianteClase({
    required this._nombre,
    required this._edad,
    required this._promedio,
  });

  void mostrarInfo() {
    print(
      'Informacion del estudiante: $_nombre, $_edad años, promedio $_promedio ',
    );
  }
}
