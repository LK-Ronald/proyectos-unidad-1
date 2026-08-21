package com.company;

public class Main {
    public static void main(String[] args) {

        Estudiante[] estudiantes = {
                new Estudiante("Ronald", 12, 3.3),
                new Estudiante("Camilo", 22, 4.4),
                new Estudiante("Jose", 18, 2.9),
                new Estudiante("Andres", 55, 2.2),
        };

        for (var e : estudiantes) { 
            System.out.println(e);
        }

    }
}

record Estudiante(String nombre, int edad, double promedio) {
}