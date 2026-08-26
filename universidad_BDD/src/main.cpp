#include <iostream>
#include "../include/Conexion.h"

int main() {
    int opcion = -1;
    do {
        system("cls");
        std::cout << "---------- BASE DE DATOS UNIVERSIDAD ----------" << std::endl;
        std::cout << "\n--- MENU PRINCIPAL ---" << std::endl;
        std::cout << "1. Cargar Alumnos" << std::endl;
        std::cout << "2. Cargar Carreras" << std::endl;
        std::cout << "3. Cargar Materias" << std::endl;
        std::cout << "0. Salir" << std::endl;
        std::cout << "Elige una opcion (1-3): ";
        
        // 2. Pedir el input al usuario
        std::cin >> opcion;
        std::cin.ignore(10000, '\n');
        
        switch(opcion) {
            case 1: {
                Conexion::insertarAlumno();
                break;
            }
            case 2: {
                Conexion::consultarCarreras();
                std::cout << "Todo funciona correctamente." << std::endl;
                break;
            }
            case 3: {
                std::cout << "Cargando materias..." << std::endl;
                break;
            }
            default: {
                break;
            }
        }
        
        std::cout << "\n Presione para continuar" << std::endl;
        std::cin.get();
        
    } while (opcion != 0);
    return 0;
}