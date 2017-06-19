using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Serialization
{
    [DataContract]
    public abstract class Item
    {
        [DataMember]
        private string name;
        [DataMember]
        private float cost;
        [DataMember]
        private int quality;
        [DataMember]
        private int count;
        [DataMember]
        private string genre;
        [DataMember]
        private int yearOfCreate;
        [DataMember]
        private DateTime publishDate;
        public Item()
        {
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
