using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJogador
{
    public class PerJogador
    {
        private string arquivo = "Lista_de_jogadores.xml";

        public List<ModJogador> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<ModJogador>));
            StreamReader f = null;
            List<ModJogador> list = null;

            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                list = x.Deserialize(f) as List<ModJogador>;
            }
            catch
            {
                list = new List<ModJogador>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return list;
        }

        public void Save(List<ModJogador> g)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<ModJogador>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, g);
            f.Close();
        }
    }
}