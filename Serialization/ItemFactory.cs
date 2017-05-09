using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class MainFactory
    {
        private Dictionary<string, object> factoryDictionary;
        private object requestedFactory;
        public Dictionary<string, object> FactoryDictionary
        {
            get
            {
                return factoryDictionary;
            }
            set
            {
                factoryDictionary = value;
            }
        }
        public void InitializeDictionary()
        {
            FactoryDictionary.Add("Book", new Book());
            FactoryDictionary.Add("MusicDisc", new MusicDisc());
            FactoryDictionary.Add("VideoFilm", new VideoFilm());
            FactoryDictionary.Add("Game", new Game());
            FactoryDictionary.Add("TShirt", new TShirt());
            FactoryDictionary.Add("Sticker", new Sticker());
        }
        public object CheckFactory(string buttonName)
        {
            return FactoryDictionary[buttonName];
        }
        public MainFactory()
        {
            this.FactoryDictionary = new Dictionary<string, object>();
            InitializeDictionary();
        }
        public dynamic RequestedFactory
        {
            get { return this.requestedFactory; }
            set
            {
                requestedFactory = value;
            }

        }
    }


}
