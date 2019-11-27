using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MPresidente;

namespace PPresidente
{
    public class PerPresidente
    {

        private string arquivo = "Lista_de_presidentes.xml";

        public List<ModPresidente> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<ModPresidente>));
            StreamReader f = null;
            List<ModPresidente> list = null;

            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                list = x.Deserialize(f) as List<ModPresidente>;
            }
            catch
            {
                list = new List<ModPresidente>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return list;
        }

        public void Save(List<ModPresidente> g)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<ModPresidente>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, g);
            f.Close();
        }
    }
}
