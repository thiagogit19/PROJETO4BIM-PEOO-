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
    public class PerEquipe
    {
        private string arquivo = "Lista_de_equipes.xml";

        public List<ModEquipe> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<ModEquipe>));
            StreamReader f = null;
            List<ModEquipe> list = null;

            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                list = x.Deserialize(f) as List<ModEquipe>;
            }
            catch
            {
                list = new List<ModEquipe>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return list;
        }

        public void Save(List<ModEquipe> g)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<ModEquipe>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, g);
            f.Close();
        }
    }
}
