using Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Utilidades
{
    public static class SerializadorXml
    {
        public static string CrearXml(Simon simon)
        {
            XmlSerializer s = new XmlSerializer(typeof(Simon));
            MemoryStream ms = new MemoryStream();
            s.Serialize(ms, simon);
            return Encoding.ASCII.GetString(ms.ToArray());
        }

        public static Simon LeerXml(string xml)
        {
            TextReader reader = new StringReader(xml);
            XmlSerializer s = new XmlSerializer(typeof(Simon));
            return s.Deserialize(reader) as Simon;
        }
    }
}
