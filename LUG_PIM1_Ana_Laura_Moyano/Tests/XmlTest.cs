using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelos;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Utilidades;

namespace Tests
{
    [TestClass]
    public class XmlTest
    {
        [TestMethod]
        public void TextoTest()
        {
            Simon simon = new Simon
            {
                Juego = 1,
                Secuencias = CreateSecuencias()
            };
            string resultado = SerializadorXml.CrearXml(simon);
            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void LecturaTest()
        {
            string xml = "<?xml version=\"1.0\"?>\r\n<Simon xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Juego>1</Juego>\r\n  <Secuencias>\r\n    <Secuencia>\r\n      <Id>1</Id>\r\n      <Valor>1</Valor>\r\n      <Anterior>0</Anterior>\r\n      <Posterior>2</Posterior>\r\n    </Secuencia>\r\n    <Secuencia>\r\n      <Id>2</Id>\r\n      <Valor>3</Valor>\r\n      <Anterior>1</Anterior>\r\n      <Posterior>3</Posterior>\r\n    </Secuencia>\r\n    <Secuencia>\r\n      <Id>3</Id>\r\n      <Valor>2</Valor>\r\n      <Anterior>2</Anterior>\r\n      <Posterior>0</Posterior>\r\n    </Secuencia>\r\n  </Secuencias>\r\n</Simon>";
            Simon resultado = SerializadorXml.LeerXml(xml);
        }

        private List<Secuencia> CreateSecuencias()
        {
            List<Secuencia> resultado = new List<Secuencia>();
            resultado.Add(new Secuencia
            {
                Id = 1,
                Anterior = 0,
                Posterior = 2,
                Valor = 1
            });

            resultado.Add(new Secuencia
            {
                Id = 2,
                Anterior = 1,
                Posterior = 3,
                Valor = 3
            });

            resultado.Add(new Secuencia
            {
                Id = 3,
                Anterior = 2,
                Posterior = 0,
                Valor = 2
            });
            return resultado;
        }
    }
}
