using Modelos;
using System;

namespace Utilidades
{
    public static class CreadorSecuencia
    {
        private static readonly Random random = new Random();

        public static Secuencia GenerarSecuencia()
        {
            return new Secuencia
            {
                Valor = random.Next(1, 5)
            };
        }
    }
}
