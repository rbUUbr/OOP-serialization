using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public abstract class Item
    {
        private string name;
        private float cost;
        private int quality;
        private int count;
        private string type;
        private int yearOfCreate;
        private DateTime publishDate;
        public Item(string name, float cost, int quality, int count, string type, int yearOfCreate, DateTime publishDate)
        {
            this.name = name;
            this.cost = cost;
            this.quality = quality;
            this.count = count;
            this.type = type;
            this.yearOfCreate = yearOfCreate;
            this.publishDate = publishDate;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Cost
        {
            get {
                return cost;
            }
            set {
                cost = value;
            }
        }

        public int Quality
        {
            get {
                return quality;
            }
            set {
                quality = value;
            }
        }

        public int Count
        {
            get {
                return count;
            }
            set {
                count = value;
            }
        }

        public string Type
        {
            get {
                return type;
            }
            set {
                type = value;
            }
        }

        public string MusicQuality
        {
            get { return musicQuality; }
            set { musicQuality = value; }
        }

        public int TrackCount
        {
            get { return trackCount; }
            set { trackCount = value; }
        }

        public int CdCount
        {
            get { return cdCount; }
            set { cdCount = value; }
        }

    }
}
}
