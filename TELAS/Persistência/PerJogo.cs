using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Modelo;

namespace Persistência
{
    public class PerJogo
    {
        private string arquivo = "Lista_de_jogos.xml";

        public List<ModJogo> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<ModJogo>));
            StreamReader f = null;
            List<ModJogo> list = null;

            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                list = x.Deserialize(f) as List<ModJogo>;
            }
            catch
            {
                list = new List<ModJogo>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return list;
        }

        public void Save(List<ModJogo> g)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<ModJogo>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, g);
            f.Close();
        }
    }
}
