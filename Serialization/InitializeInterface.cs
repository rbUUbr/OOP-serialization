using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization
{
    class ApiClass
    {
        private List<Item> itemsList;
        public List<Item> ItemsList
        {
            get
            {
                return itemsList;
            }
            set
            {
                itemsList = value;
            }
        }
        private MainFactory mainFactory;
        public MainFactory MainFactory
        {
            get
            {
                return mainFactory;
            }
            set
            {
                mainFactory = value;
            }
        }

        public List<Control> GetTextBoxes(Form form)
        {
            var textBoxes = new List<Control>();
            foreach (Control c in form.Controls)
            {   
                if (c is TextBox)
                {
                    textBoxes.Add(c);
                }
            }
            return textBoxes;
        }

        public void InitializeObjects(ref Type[] ItemsTypes)
        {
            Item plugin;
             Assembly asm = Assembly.LoadFile(Directory.GetCurrentDirectory() + @"\AdditionalClasses.dll");
            foreach (Type t in asm.GetExportedTypes())
            {
                if (typeof(Item).IsAssignableFrom(t))
                {
                    plugin = (Item)asm.CreateInstance(t.FullName);
                    MainFactory.FactoryDictionary.Add(plugin.GetType().Name, plugin);
                    Array.Resize(ref ItemsTypes, ItemsTypes.Length + 1);
                    ItemsTypes[ItemsTypes.Length - 1] = plugin.GetType();
                }
            }
        }
        public void Serialize(Type[] ItemsTypes, string FileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Item>), ItemsTypes);
            try
            {
                using (FileStream fs = new FileStream(FileName, FileMode.Truncate))
                {
                    serializer.Serialize(fs, ItemsList);
                    fs.Close();
                }
            }
            catch
            {
                MessageBox.Show("Путь не может быть пустым!");
            }
        }
        public List<Item> Deserialize(Type[] ItemsTypes, string FileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Item>), ItemsTypes);
            XmlReader reader = XmlReader.Create(FileName);
            return (List<Item>)serializer.Deserialize(reader);
        }
        public ApiClass()
        {
            MainFactory = new MainFactory();
            ItemsList = new List<Item>();
        }
    }
}
