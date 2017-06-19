using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using static System.Object;
using System.Web.Extensions;

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
            File.WriteAllText(fileOutPath, new  JavaScriptSerializer().Serialize(GetXmlValues(XElement.Parse(xmlContent))));
        }

        private Dictionary<string, object> GetXmlValues(XElement xml)
        {
            var attr = xml.Attributes().ToDictionary(
                item => item.Name.LocalName,
                item => (object)item.Value
            );

            if (xml.HasElements)
            {
                attr.Add("_value", xml.Elements().Select(
                    e => GetXmlValues(e)
                ));
            }
            else if (!xml.IsEmpty)
            {
                attr.Add("_value", xml.Value);
            }

            return new Dictionary<string, object> { { xml.Name.LocalName, attr } };
        }

    }
}
