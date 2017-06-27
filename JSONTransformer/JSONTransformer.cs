using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using static System.Object;
using System.Xml;
using static Newtonsoft.Json.JsonConvert;
using System.Web;
namespace JSONTransformer
{
    public class JSONTransformer
    {
        private static JSONTransformer instance;
        private JSONTransformer() { }

        public static JSONTransformer GetInstance()
        {
            if (instance == null) { instance = new JSONTransformer(); }
            return instance;
        }


        public void XmlToJson(string fileInPath, string fileOutPath)
        {
            string xmlContent = File.ReadAllText(fileInPath);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText(fileInPath));
            string jsonText = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);
            File.WriteAllText(fileOutPath, jsonText);
        }
        public void Deserialize()
        {

        }

    }
}
