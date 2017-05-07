﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
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
            Game GameExmpl = new Game();
            GameExmpl.Name = "DOOM";
            itemsList.Add(Example);
            Type[] ItemsTypes = { typeof(VideoFilm), typeof(MusicDisc), typeof(Game), typeof(Book), typeof(TShirt), typeof(Sticker) };
            itemsList.Add(Exm2);
            itemsList.Add(GameExmpl);
            XmlSerializer serializer = new XmlSerializer( typeof(List<Item>), ItemsTypes);
            using (FileStream fs = new FileStream("D://persons.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, itemsList);
            }
            deserialize();
            InitializeComponent();
        }
        public static void deserialize()
        {
            List<Item> itemsList = new List<Item>();
            Type[] ItemsTypes = { typeof(VideoFilm), typeof(MusicDisc), typeof(Game), typeof(Book), typeof(TShirt), typeof(Sticker) };

            XmlSerializer serializer = new XmlSerializer(typeof(List<Item>), ItemsTypes);
            XmlReader reader = XmlReader.Create("D://persons.xml");
            itemsList = (List<Item>)serializer.Deserialize(reader);
        }
    }
}
