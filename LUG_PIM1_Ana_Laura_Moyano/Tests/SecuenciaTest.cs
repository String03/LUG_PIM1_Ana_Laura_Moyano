using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using Utilidades;

namespace Tests
{
    [TestClass]
    public class SecuenciaTest
    {
        [TestMethod]
        public void CrearSecuenciaTest()
        {
            Simon simon = new Simon();
            simon.Juego = 1;
            simon.AgregarSecuencia(CreadorSecuencia.GenerarSecuencia());
            simon.AgregarSecuencia(CreadorSecuencia.GenerarSecuencia());
            simon.AgregarSecuencia(CreadorSecuencia.GenerarSecuencia());
            simon.AgregarSecuencia(CreadorSecuencia.GenerarSecuencia());
            simon.AgregarSecuencia(CreadorSecuencia.GenerarSecuencia());
        }
    }
}
