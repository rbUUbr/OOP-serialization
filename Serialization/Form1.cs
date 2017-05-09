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
using System.Xml;
using System.Xml.Serialization;

namespace Serialization
{
    public partial class Form1 : Form
    {
        [XmlArray("itemsList")]
        private List<Item> itemsList;
        MainFactory mainFactory = new MainFactory();
        public int CurrentIndex;
        private Type[] ItemsTypes = { typeof(VideoFilm), typeof(MusicDisc), typeof(Game), typeof(Book), typeof(TShirt), typeof(Sticker) };
        public Form1()
        {
            this.itemsList = new List<Item>();
            InitializeComponent();
        }

        public void ChangeVisible(bool value)
        {
            labelSize.Visible = value;
            comboBoxSize.Visible = value;
        }
        public static void Serialize(Type[] ItemsTypes, List<Item> itemsList, string FileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Item>), ItemsTypes);
            using (FileStream fs = new FileStream(FileName, FileMode.Truncate))
            {
                serializer.Serialize(fs, itemsList);
                fs.Close();
            }
        }
        public List<Item> Deserialize(Type[] ItemsTypes, string FileName)
        {
      
            XmlSerializer serializer = new XmlSerializer(typeof(List<Item>), ItemsTypes);
            XmlReader reader = XmlReader.Create(FileName);
            return (List<Item>)serializer.Deserialize(reader);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
                string FileName = SaveToFile();
                Serialize(ItemsTypes, this.itemsList, FileName);
            
        }
        public void SetValues(Item MyItem)
        {
            MyItem.Name = textBoxName.Text;
            try
            {
                MyItem.Quality = Convert.ToInt32(textBoxQuality.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка! Неудовлетворительное значение в поле 'качество'");
            }
            try
            {
                MyItem.Cost = (float)Convert.ToDouble(textBoxCost.Text) ;
            }
            catch
            {
                MessageBox.Show("Ошибка! Неудовлетворительное значение в поле 'цена'");
            }
            try
            {
                MyItem.Count = Convert.ToInt32(textBoxCount.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка! Неудовлетворительное значение в поле 'количество'");
            }
            try
            {
                MyItem.YearOfCreate = Convert.ToInt32(textBoxYearOfCreate.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка! Неудовлетворительное значение в поле 'год создания'");
            }
            try
            {
                MyItem.Name = textBoxName.Text;
            }
            catch
            {
                MessageBox.Show("Ошибка! Неудовлетворительное значение в поле 'имя'");
            }
            MyItem.PublishDate = dateTimePickerPublishDate.Value;
        }
        public string ChooseFile()
        {
            openFileDialogSerialization.DefaultExt = "*.xml";
            openFileDialogSerialization.Filter = "Файлы XML|*.xml";
            if (openFileDialogSerialization.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return openFileDialogSerialization.FileName;
            else return null;

        }
        public void SetValuesToFields(Item MyItem)
        {
            textBoxCost.Text = MyItem.Cost.ToString();
            textBoxCount.Text = MyItem.Count.ToString();
            textBoxName.Text = MyItem.Name;
            textBoxQuality.Text = MyItem.Quality.ToString();
            dateTimePickerPublishDate.Value = MyItem.PublishDate;
            textBoxYearOfCreate.Text = MyItem.YearOfCreate.ToString();

        }
        private void listBoxOfElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOfElements.SelectedIndex < 0) return;
            CurrentIndex = listBoxOfElements.SelectedIndex;
            Item SettedItem = itemsList.ElementAt(listBoxOfElements.SelectedIndex);
            SetValuesToFields(SettedItem);
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboBoxClass.SelectedItem.ToString() == "TShirt") || (comboBoxClass.SelectedItem.ToString() == "Sticker"))
            {
                ChangeVisible(true);
            }
            else
            {
                ChangeVisible(false);
            }
        }
        public string SaveToFile()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "*.xml";
            saveDialog.Filter = "Файлы XML|*.xml";
            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return saveDialog.FileName;
            else return null;

        }

        private void десериализоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName = ChooseFile();
            itemsList.Clear();
            listBoxOfElements.Items.Clear();
            itemsList = Deserialize(ItemsTypes, FileName);
            for (int i = 0; i < itemsList.Count; i++)
            {
                try
                {
                    listBoxOfElements.Items.Add(itemsList[i].Name);
                   
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                mainFactory.RequestedFactory = mainFactory.CheckFactory(comboBoxClass.SelectedItem.ToString());
                SetValues(mainFactory.RequestedFactory);
                itemsList.Add(mainFactory.RequestedFactory);
                listBoxOfElements.Items.Add(mainFactory.RequestedFactory.Name);
            }
            catch
            {
                MessageBox.Show("Выберите класс создаваемого объекта!");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SetValues(itemsList.ElementAt(CurrentIndex));
            listBoxOfElements.Items[CurrentIndex] = itemsList.ElementAt(CurrentIndex).Name;
        }
    }
}
