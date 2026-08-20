void main() {
  
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
      "Informacion del estudiante: $_nombre, $_edad años, promedio $_promedio ",
    );
  }
}
