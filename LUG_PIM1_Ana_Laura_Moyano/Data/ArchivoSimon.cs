using Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Data
{
    public static class ArchivoSimon
    {
        public static Simon LeerArchivo(string ruta)
        {
            return LeerArchivo(new FileStream(ruta, FileMode.Open));
        }

        public static Simon LeerArchivo(FileStream archivo)
        {
            using (StreamReader reader = new StreamReader(archivo))
            {
                string xml = reader.ReadToEnd();
                return SerializadorXml.LeerXml(xml);
            }
        }

        public static void GuardarArchivo(string ruta, Simon simon)
        {
            GuardarArchivo(new FileStream(ruta, FileMode.Create), simon);
        }

        public static void GuardarArchivo(FileStream archivo, Simon simon)
        {
            using (StreamWriter writer = new StreamWriter(archivo))
            {
                string xml = SerializadorXml.CrearXml(simon);
                writer.WriteLine(xml);
            }
        }
    }
}
