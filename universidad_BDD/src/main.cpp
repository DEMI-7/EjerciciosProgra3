#include <iostream>
#include "../include/Conexion.h"


void menuPrincipal() {
    int opcion = -1;
    do {
        system("cls");
        std::cout << "---------- BASE DE DATOS UNIVERSIDAD ----------" << std::endl;
        std::cout << "\n" << std::endl;
        std::cout << "1. Alumnos" << std::endl;
        std::cout << "2. Carreras" << std::endl;
        std::cout << "3. Materias" << std::endl;
        std::cout << "0. Salir" << std::endl;
        std::cout << "Elige una opcion: ";
        
        // 2. Pedir el input al usuario
        std::cin >> opcion;
        std::cin.ignore(10000, '\n');
        
        switch(opcion) {
            case 1: {
                menuAlumnos();
                break;
            }
            case 2: {
                menuCarreras();
                break;
            }
            case 3: {
                menuMaterias();
                break;
            }
            default: {
                break;
                }
            }
        std::cout << "\n Presione para continuar" << std::endl;
        std::cin.get();
    } while (opcion != 0);
}

void menuAlumnos() {
    int opcion = -1;
    do {
        system("cls");
        std::cout << "---------- ALUMNOS ----------" << std::endl;
        std::cout << "\n" << std::endl;
        std::cout << "1. Registrar Alumnos" << std::endl;
        std::cout << "2. Mostrar Alumnos" << std::endl;
        std::cout << "3. Buscar Alumnos" << std::endl;
        std::cout << "0. Volver a inicio" << std::endl;
        std::cout << "Elige una opcion: ";
        
        // 2. Pedir el input al usuario
        std::cin >> opcion;
        std::cin.ignore(10000, '\n');
        
        switch(opcion) {
            case 1: {
                //Conexion::insertarAlumno();
                std::cout << "Iniciar registro nuevo alumno" << std::endl;
                break;
            }
            case 2: {
                //Conexion::consultarCarreras();
                std::cout << "Mostrar todos los registros" << std::endl;
                break;
            }
            case 3: {
                std::cout << "Busqueda por nombre, apellido, dni o legajo" << std::endl;
                break;
            }
            default: {
                break;
                }
            }
        std::cout << "\n Presione para continuar" << std::endl;
        std::cin.get();
    } while (opcion != 0);
}

int main() {
    menuPrincipal();
    return 0;
}