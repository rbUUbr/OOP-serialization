using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    public partial class Form1 : Form
    {
        [XmlArray("itemsList")]
        private List<Item> itemsList;
        public Form1()
        {
            this.itemsList = new List<Item>();
            MusicDisc Example = new MusicDisc();
            Example.Name = "123";
            VideoFilm Exm2 = new VideoFilm();
            itemsList.Add(Example);
            Type[] ItemsTypes = { typeof(VideoFilm), typeof(MusicDisc) };
            itemsList.Add(Exm2);
            XmlSerializer serializer = new XmlSerializer( typeof(List<Item>), ItemsTypes);
            using (FileStream fs = new FileStream("D://persons.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, itemsList);
            }
            InitializeComponent();
        }
    }
}
