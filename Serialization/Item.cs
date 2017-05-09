using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.ComboBox;
namespace Serialization
{
    public abstract class Item
    {
        private string name;
        private float cost;
        private int quality;
        private int count;
        private string genre;
        private int yearOfCreate;
        private DateTime publishDate;
        public string InstanceID { get; set; }
        public Item()
        {
            InstanceID = Guid.NewGuid().ToString();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }

        public float Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }

        public int Quality
        {
            get
            {
                return quality;
            }
            set
            {
                quality = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        public int YearOfCreate
        {
            get
            {
                return yearOfCreate;
            }
            set
            {
                yearOfCreate = value;
            }
        }

        public DateTime PublishDate
        {
            get
            {
                return publishDate;
            }
            set
            {
                publishDate = value;
            }
        }
    }
}
