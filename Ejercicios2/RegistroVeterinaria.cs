using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Ejercicios2
{
    public static class RegistroVeterinaria
    {
        private static int Id = 0;

        public static int GenerarId()
        {
            Id++;
            return Id;
        }
    }
}
