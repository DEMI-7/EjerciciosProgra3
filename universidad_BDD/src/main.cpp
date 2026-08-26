#include <iostream>
#include <windows.h>
#include <sqlext.h>
#include <sqltypes.h>
#include <sql.h>

void consultarCarreras() {
    SQLHENV env;
    SQLHDBC dbc;
    SQLHSTMT stmt;
    SQLRETURN ret;

    // 1. Iniciar entorno ODBC
    SQLAllocHandle(SQL_HANDLE_ENV, SQL_NULL_HANDLE, &env);
    SQLSetEnvAttr(env, SQL_ATTR_ODBC_VERSION, (void*)SQL_OV_ODBC3, 0);
    SQLAllocHandle(SQL_HANDLE_DBC, env, &dbc);

    // 2. Cadena de conexión
    SQLWCHAR connectionString[] = L"DRIVER={ODBC Driver 18 for SQL Server};"
                                    L"SERVER=127.0.0.1;"
                                    L"DATABASE=universidad;"
                                    L"UID=sa;"
                                    L"PWD=Demi1234!;"
                                    L"Encrypt=yes;"
                                    L"TrustServerCertificate=yes;";
    SQLWCHAR outConnStr[1024];
    SQLSMALLINT outConnStrLen;

    std::cout << "Conectando a la base de datos..." << std::endl;
    ret = SQLDriverConnectW(dbc, NULL, connectionString, SQL_NTS, outConnStr, sizeof(outConnStr) / sizeof(SQLWCHAR), &outConnStrLen, SQL_DRIVER_NOPROMPT);

    if (SQL_SUCCEEDED(ret)) {
        std::cout << "Conexion exitosa!\n" << std::endl;
        SQLAllocHandle(SQL_HANDLE_STMT, dbc, &stmt);

        // 3. Query de SQL
        SQLWCHAR* query = (SQLWCHAR*)L"SELECT Id, Nombre, Nivel FROM Carreras";
        ret = SQLExecDirectW(stmt, query, SQL_NTS);

        if (SQL_SUCCEEDED(ret)) {
            // Variables de almacenamiento de las columas de la BDD
            SQLWCHAR id[5];
            SQLWCHAR nombre[51];
            SQLWCHAR nivel[21];
            SQLLEN cbId, cbNombre, cbNivel;

            std::cout << "----- LISTADO DE CARRERAS ---" << std::endl;
            // 4. Recorrer los resultados fila por fila
            while (SQLFetch(stmt) == SQL_SUCCESS) {
                SQLGetData(stmt, 1, SQL_C_WCHAR, id, sizeof(id), &cbId);
                SQLGetData(stmt, 2, SQL_C_WCHAR, nombre, sizeof(nombre), &cbNombre);
                SQLGetData(stmt, 3, SQL_C_WCHAR, nivel, sizeof(nivel), &cbNivel);

                std::wcout << L"[" << id << L"]" << nombre << L" (" << nivel << L")" << std::endl;
            }
        } else {
            std::cout << "Error al ejecutar la consulta." << std::endl;
        }

        //Liberar el manejador de la consulta
        SQLFreeHandle(SQL_HANDLE_STMT, stmt);
    } else {
        std::cout << "Error al conectar. Verifica que el contenedor Docker este corriendo y el Driver instalado." << std::endl;
    }

    // 5. Cerrar conexiones y limpiar memoria
    SQLDisconnect(dbc);
    SQLFreeHandle(SQL_HANDLE_DBC, dbc);
    SQLFreeHandle(SQL_HANDLE_ENV, env);
}

void insertarAlumno() {
    SQLHENV env; SQLHDBC dbc; SQLHSTMT stmt; SQLRETURN ret;
    SQLAllocHandle(SQL_HANDLE_ENV, SQL_NULL_HANDLE, &env);
    SQLSetEnvAttr(env, SQL_ATTR_ODBC_VERSION, (void*)SQL_OV_ODBC3, 0);
    SQLAllocHandle(SQL_HANDLE_DBC, env, &dbc);

    // Tu cadena de conexión con los parámetros de confianza para Docker
    SQLWCHAR connectionString[] = L"DRIVER={ODBC Driver 18 for SQL Server};"
                                  L"SERVER=127.0.0.1;"
                                  L"DATABASE=universidad;"
                                  L"UID=sa;"
                                  L"PWD=Demi1234!;"
                                  L"Encrypt=yes;"
                                  L"TrustServerCertificate=yes;";
    
    SQLWCHAR outConnStr[1024]; SQLSMALLINT outConnStrLen;
    ret = SQLDriverConnectW(dbc, NULL, connectionString, SQL_NTS, outConnStr, sizeof(outConnStr) / sizeof(SQLWCHAR), &outConnStrLen, SQL_DRIVER_NOPROMPT);

    if (SQL_SUCCEEDED(ret)) {
        SQLAllocHandle(SQL_HANDLE_STMT, dbc, &stmt);

        // 1. Buffers fijos para capturar texto Unicode de consola
        SQLWCHAR idCarrera[5];   // VARCHAR(4) + 1 para el nulo terminador
        SQLWCHAR apellido[51];   // VARCHAR(50) + 1
        SQLWCHAR nombre[51];     // VARCHAR(50) + 1
        SQLWCHAR mail[51];       // VARCHAR(50) + 1
        long long telefono = 0;  // BIGINT
        int tieneTelefono = 0;

        std::cout << "\n--- REGISTRAR ALUMNO ---" << std::endl;
        std::cout << "Codigo de carrera (ej: sist): "; std::wcin >> idCarrera;
        std::cout << "Apellido: ";                     std::wcin >> apellido;
        std::cout << "Nombre: ";                       std::wcin >> nombre;
        std::cout << "Email: ";                        std::wcin >> mail;
        std::cout << "Tiene telefono? (1 = Si, 0 = No): "; std::wcin >> tieneTelefono;

        if (tieneTelefono == 1) {
            std::cout << "Ingrese el numero (solo digitos): ";
            std::wcin >> telefono;
        }

        // 2. Query parametrizado usando '?' (FechaNacimiento usa GETDATE() para simplificar)
        SQLWCHAR* query = (SQLWCHAR*)L"INSERT INTO Alumnos (IdCarrera, Apellido, Nombre, FechaNacimiento, Mail, Telefono) "
                                      L"VALUES (?, ?, ?, GETDATE(), ?, ?)";
        
        SQLPrepareW(stmt, query, SQL_NTS);

        // Variables indicadoras de longitud para cada parámetro
        SQLLEN cbId = SQL_NTS, cbAp = SQL_NTS, cbNom = SQL_NTS, cbMail = SQL_NTS, cbTel;

        // Configuración mágica del NULL para el teléfono
        if (tieneTelefono == 1) {
            cbTel = 0; // Envía el número real
        } else {
            cbTel = SQL_NULL_DATA; // Envía un NULL a SQL Server
        }

        // 3. Vincular los 5 parámetros en orden de los '?'
        SQLBindParameter(stmt, 1, SQL_PARAM_INPUT, SQL_C_WCHAR, SQL_VARCHAR, 4, 0, idCarrera, sizeof(idCarrera), &cbId);
        SQLBindParameter(stmt, 2, SQL_PARAM_INPUT, SQL_C_WCHAR, SQL_VARCHAR, 50, 0, apellido, sizeof(apellido), &cbAp);
        SQLBindParameter(stmt, 3, SQL_PARAM_INPUT, SQL_C_WCHAR, SQL_VARCHAR, 50, 0, nombre, sizeof(nombre), &cbNom);
        SQLBindParameter(stmt, 4, SQL_PARAM_INPUT, SQL_C_WCHAR, SQL_VARCHAR, 50, 0, mail, sizeof(mail), &cbMail);
        SQLBindParameter(stmt, 5, SQL_PARAM_INPUT, SQL_C_SBIGINT, SQL_BIGINT, 0, 0, &telefono, 0, &cbTel);

        // 4. Ejecutar el insert preparado
        ret = SQLExecute(stmt);

        if (SQL_SUCCEEDED(ret)) {
            std::cout << "\n[OK] Alumno registrado exitosamente en la base de datos!" << std::endl;
        } else {
            std::cout << "\n[ERROR] No se pudo guardar. Verifica que el codigo de carrera exista en SQL Server." << std::endl;
        }

        SQLFreeHandle(SQL_HANDLE_STMT, stmt);
    } else {
        std::cout << "Error critico de conexion." << std::endl;
    }

    SQLDisconnect(dbc); SQLFreeHandle(SQL_HANDLE_DBC, dbc); SQLFreeHandle(SQL_HANDLE_ENV, env);
}

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
                insertarAlumno();
                break;
            }
            case 2: {
                consultarCarreras();
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