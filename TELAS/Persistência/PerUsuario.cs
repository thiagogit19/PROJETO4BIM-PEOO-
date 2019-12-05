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
    public class PerUsuario
    {
        private string arquivo = "Lista_de_usuarios.xml";

        public List<ModUsuario> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<ModUsuario>), new Type[] { typeof(ModAdm), typeof(ModPresidente), typeof(ModJogador) });
            StreamReader f = null;
            List<ModUsuario> list = null;

            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                list = x.Deserialize(f) as List<ModUsuario>;
            }
            catch
            {
                list = new List<ModUsuario>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return list;
        }

        public void Save(List<ModUsuario> g)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<ModUsuario>), new Type[] {typeof(ModAdm), typeof(ModPresidente), typeof(ModJogador)});
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, g);
            f.Close();
        }
    }
}
