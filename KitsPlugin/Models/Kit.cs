using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KitsPlugin.Models
{
    public class Kit
    {
        public string Name { get; set; }
        public int Cooldown { get; set; }

        [XmlElement("Item")]
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        [XmlAttribute("id")]
        public ushort Id { get; set; }

        [XmlAttribute("amount")]
        public ushort Amount { get; set; } = 1;
    }
}

