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
        private ApiClass api = new ApiClass();        
        public int CurrentIndex;
        private List<Control> textBoxes;
        Type[] ItemsTypes = { typeof(VideoFilm), typeof(MusicDisc), typeof(Game), typeof(Book), typeof(TShirt), typeof(Sticker) };
        public Form1()
        {
            string[] PropertiesNames = GetNameOfFields();
            InitializeComponent();
            this.api.InitializeObjects(ref ItemsTypes);
            comboBox1.Items.Clear();
            foreach (string element in PropertiesNames)
            {
                comboBox1.Items.Add(element);
            }

        }



        public void ChangeVisible(bool value)
        {
            labelSize.Visible = value;
            textBoxSize.Visible = value;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
                string FileName = SaveToFile();
            if (openFileDialogSerialization.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.api.Serialize(ItemsTypes, FileName);
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
            Type MyType = api.MainFactory.ReturnTypeOfObject(MyItem);
            string[] PropertiesNames = GetNameOfFields();
            string MyProperty = PropertiesNames[comboBox1.SelectedIndex].ToString();
            PropertyInfo a = MyType.GetProperty(MyProperty);
            textBoxSize.Text = a.GetValue(MyItem, null).ToString();

        }
        private void listBoxOfElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOfElements.SelectedIndex < 0) return;
            CurrentIndex = listBoxOfElements.SelectedIndex;
            Item SettedItem = this.api.ItemsList.ElementAt(listBoxOfElements.SelectedIndex);
            SetValuesToFields(this.api.ItemsList.ElementAt(listBoxOfElements.SelectedIndex));
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
                this.api.ItemsList.Clear();
                listBoxOfElements.Items.Clear();
                this.api.ItemsList = this.api.Deserialize(ItemsTypes, FileName);
                for (int i = 0; i < this.api.ItemsList.Count; i++)
                {
                    try
                    {
                        listBoxOfElements.Items.Add(this.api.ItemsList[i].Name);

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
                this.api.MainFactory.RequestedFactory = this.api.MainFactory.CheckFactory(comboBoxClass.SelectedItem.ToString());
                SetValues(this.api.MainFactory.RequestedFactory);
                this.api.ItemsList.Add(this.api.MainFactory.RequestedFactory);
                listBoxOfElements.Items.Add(this.api.MainFactory.RequestedFactory.Name);
                Type MyType = this.api.MainFactory.ReturnTypeOfObject(this.api.MainFactory.RequestedFactory);
                string MyProperty = PropertiesNames[comboBoxClass.SelectedIndex].ToString();
                PropertyInfo a = MyType.GetProperty(MyProperty);
                a.SetValue(this.api.MainFactory.RequestedFactory, textBoxSize.Text, null);
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
                SetValues(this.api.ItemsList.ElementAt(CurrentIndex));
                listBoxOfElements.Items[CurrentIndex] = this.api.ItemsList.ElementAt(CurrentIndex).Name;

            }
            catch
            {
                MessageBox.Show("Эта функция предназначена для редактирования уже существующих элементов!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxOfElements.SelectedIndex < 0) return;
            this.api.ItemsList.RemoveAt(CurrentIndex);
            listBoxOfElements.Items.RemoveAt(CurrentIndex);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public string[] GetNameOfFields()
        {
            string[] FieldsInfo = new string[]{ "Author", "AlbumType", "Resolution", "HardLevel", "SizeFields", "SizeFields", "Material", "Firm" };
            return FieldsInfo;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, object> f in api.MainFactory.FactoryDictionary)
            {
                comboBoxClass.Items.Add(f.Key);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBoxes = this.api.GetTextBoxes(this);
        }
    }
}
