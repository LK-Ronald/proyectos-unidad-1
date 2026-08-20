void main() {
  List<Estudiante> estudiantes = [
    Estudiante(nombre: "Ronald", edad: 15, promedio: 5.0),
    Estudiante(nombre: "Camilo", edad: 45, promedio: 3.5),
    Estudiante(nombre: "Jose", edad: 15, promedio: 2.0),
  ];

  for (var e in estudiantes) {
    e.mostrarInfo();
  }
}

class Estudiante {
  String _nombre;
  int _edad;
  double _promedio;

  Estudiante({
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
