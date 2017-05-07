using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Serialization
{
    public abstract class Item
    {
        private string name;
        private float cost;
        private int quality;
        private int count;
        private string type;
        private int genre;
        private int yearOfCreate;
        private DateTime publishDate;
        enum GenreOfItem {};
        public Item()
        {
        }
        public Item(string name, float cost, int quality, int genre, int count, int yearOfCreate, DateTime publishDate)
        {
            this.Name = name;
            this.Cost = cost;
            this.Quality = quality;
            this.Count = count;
            this.Genre = genre;
            this.YearOfCreate = yearOfCreate;
            this.PublishDate = publishDate;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Genre
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

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
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
