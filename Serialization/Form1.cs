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
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization
{
    public partial class Form1 : Form
    {
        [XmlArray("itemsList")]
        private List<Item> itemsList;
        MainFactory mainFactory = new MainFactory();
        Item plugin;
        public int CurrentIndex;
        private Type[] ItemsTypes = { typeof(VideoFilm), typeof(MusicDisc), typeof(Game), typeof(Book), typeof(TShirt), typeof(Sticker) };
        public Form1()
        {
            this.itemsList = new List<Item>();
            InitializeComponent();
            Assembly asm = Assembly.LoadFile(@"D:\Serialization\AdditionalClasses\bin\Debug\AdditionalClasses.dll");
            foreach (Type t in asm.GetExportedTypes())
            {
                if (typeof(Item).IsAssignableFrom(t))
                {
                    plugin = (Item)asm.CreateInstance(t.FullName);
                    mainFactory.FactoryDictionary.Add(plugin.GetType().Name, plugin);
                    Array.Resize(ref this.ItemsTypes, this.ItemsTypes.Length + 1);
                    this.ItemsTypes[this.ItemsTypes.Length - 1] = plugin.GetType();
                }
            }

            foreach (KeyValuePair<string, object> f in mainFactory.FactoryDictionary)
            {
                comboBoxClass.Items.Add(f.Key);
            }
            string[] PropertiesNames = GetNameOfFields();
            comboBox1.Items.Add(PropertiesNames);

    }

        public void ChangeVisible(bool value)
        {
            labelSize.Visible = value;
            textBoxSize.Visible = value;
        }
        public static void Serialize(Type[] ItemsTypes, List<Item> itemsList, string FileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Item>), ItemsTypes);
            try
            {
                using (FileStream fs = new FileStream(FileName, FileMode.Truncate))
                {
                    serializer.Serialize(fs, itemsList);
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

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
                string FileName = SaveToFile();
            if (openFileDialogSerialization.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Serialize(ItemsTypes, this.itemsList, FileName);
            }
            
        }
        public void SetValues(dynamic MyItem)
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
            MyItem.Genre = textBoxGenre.Text;

        }
        public string ChooseFile()
        {
            openFileDialogSerialization.DefaultExt = "*.xml";
            openFileDialogSerialization.Filter = "Файлы XML|*.xml";
            if (openFileDialogSerialization.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return openFileDialogSerialization.FileName;
            else return null;

        }
        public void SetValuesToFields(dynamic MyItem)
        {
            textBoxCost.Text = MyItem.Cost.ToString();
            textBoxCount.Text = MyItem.Count.ToString();
            textBoxName.Text = MyItem.Name;
            textBoxGenre.Text = MyItem.Genre;
            textBoxQuality.Text = MyItem.Quality.ToString();
            dateTimePickerPublishDate.Value = MyItem.PublishDate;
            textBoxYearOfCreate.Text = MyItem.YearOfCreate.ToString();
            comboBoxClass.SelectedIndex = comboBoxClass.Items.IndexOf(MyItem.GetType().Name);
            Type MyType = mainFactory.ReturnTypeOfObject(MyItem);
            string[] PropertiesNames = GetNameOfFields();
            string MyProperty = PropertiesNames[comboBox1.SelectedIndex].ToString();
            PropertyInfo a = MyType.GetProperty(MyProperty);
            textBoxSize.Text = a.GetValue(MyItem, null).ToString();

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
            comboBox1.SelectedIndex = comboBoxClass.SelectedIndex;
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
            if (FileName != "")
            {
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
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string[] PropertiesNames = GetNameOfFields();
                mainFactory.RequestedFactory = mainFactory.CheckFactory(comboBoxClass.SelectedItem.ToString());
                SetValues(mainFactory.RequestedFactory);
                itemsList.Add(mainFactory.RequestedFactory);
                listBoxOfElements.Items.Add(mainFactory.RequestedFactory.Name);
                Type MyType = mainFactory.ReturnTypeOfObject(mainFactory.RequestedFactory);
                string MyProperty = PropertiesNames[comboBoxClass.SelectedIndex].ToString();
                PropertyInfo a = MyType.GetProperty(MyProperty);
                a.SetValue(mainFactory.RequestedFactory, textBoxSize.Text, null);
            }
            catch
            {
                MessageBox.Show("Выберите класс создаваемого объекта!");
            }



        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SetValues(itemsList.ElementAt(CurrentIndex));
                listBoxOfElements.Items[CurrentIndex] = itemsList.ElementAt(CurrentIndex).Name;

            }
            catch
            {
                MessageBox.Show("Эта функция предназначена для редактирования уже существующих элементов!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxOfElements.SelectedIndex < 0) return;
            itemsList.RemoveAt(CurrentIndex);
            listBoxOfElements.Items.RemoveAt(CurrentIndex);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public string[] GetNameOfFields()
        {
            string[] FieldsInfo = new string[]{ "Author", "AlbumType", "Resolution", "HardLevel", "SizeFields", "SizeFields", "Firm"};
            return FieldsInfo;
        }
    }
}
