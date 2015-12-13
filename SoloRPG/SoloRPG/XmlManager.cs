using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
namespace SoloRPG
{
    public class XmlManager<T>
    {
        public Type Type;

        public XmlManager()
        {
            Type = typeof(T);
        }

        public T Load(string path)
        {
            T instance;

                using (TextReader reader = new StreamReader(path))
                {
                    XmlSerializer xml = new XmlSerializer(Type);
                    instance = (T)xml.Deserialize(reader);
                }
                return instance;
        }

        public void Save(string path, object obj)
        {
            using (Stream stream = File.Open(path, FileMode.Create))
            {
                XmlSerializer x = new XmlSerializer(Type);
                x.Serialize(stream, obj);
            }
        }
    }
}
