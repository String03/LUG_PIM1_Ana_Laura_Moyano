using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Simon
    {
        public int Juego { get; set; }
        public List<Secuencia> Secuencias { get; set; }

        public Simon()
        {
            Secuencias = new List<Secuencia>();
        }

        public void AgregarSecuencia(Secuencia secuencia)
        {
            secuencia.Id = Secuencias.Count + 1;
            if (Secuencias.Count == 0)
            {
                secuencia.Anterior = 0;
            }
            else
            {
                secuencia.Anterior = Secuencias[Secuencias.Count - 1].Id;
                Secuencias[Secuencias.Count - 1].Posterior = secuencia.Id;
            }
            Secuencias.Add(secuencia);
        }
    }
}
