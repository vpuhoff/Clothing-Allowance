using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SimpleNetScanner
{
    public class Config
    {
        [XmlElement("Name")]
        public string Name { get; set; } // Это будет элементом

        [XmlAttribute("Value")]
        public string Value { get; set; } // Это будет атрибутом

        [XmlIgnore]
        public string ServiceField { get; set; } // Это поле мы не хотим сериализовать/десериализовать

        public Config(string nam, string val)
        {
            Name = nam;
            Value = val;
        }

        public Config()
        {

        }

    }

    public class ConfigCollection
    {
        [XmlArray("Collection"), XmlArrayItem("Item")]
        public List<Config> Collection { get; set; }

        public ConfigCollection()
        {
            Collection = new List<Config>();
        }
        public void Load(string fn)
        {
            string xml = File.ReadAllText(fn);
            var xmlSerializer = new XmlSerializer(typeof(List<Config>));
            var stringReader = new StringReader(xml);
            Collection = (List<Config>)xmlSerializer.Deserialize(stringReader);
        }

        public void Save(string fn)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Config>));
            StringWriter stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, Collection); // myClassCollection - наши данные
            string xml = stringWriter.ToString();
            File.WriteAllText(fn, xml);
        }
    }
}
