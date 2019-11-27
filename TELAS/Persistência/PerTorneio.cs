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
    public class PerTorneio
    {
        private string arquivo = "Lista_de_torneio.xml";

        public List<ModTorneio> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<ModTorneio>));
            StreamReader f = null;
            List<ModTorneio> list = null;

            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                list = x.Deserialize(f) as List<ModTorneio>;
            }
            catch
            {
                list = new List<ModTorneio>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return list;
        }

        public void Save(List<ModTorneio> g)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<ModTorneio>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, g);
            f.Close();
        }
    }
}
