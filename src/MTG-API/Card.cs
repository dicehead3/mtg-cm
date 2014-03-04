using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MTG_API
{
    [DataContract]
    public class Card
    {
        [DataMember]
        public int Id;

        [DataMember]
        public int SetNumber;

        [DataMember]
        public string Name;

        [DataMember]
        public string SearchName;

        [DataMember]
        public string Description;

        [DataMember]
        public string Flavor;

        [DataMember]
        public IEnumerable<string> Colors;

        [DataMember]
        public string Manacost;

        [DataMember]
        public int ConvertedManaCost;

        [DataMember]
        public string CardSetName;

        [DataMember]
        public int Power;

        [DataMember]
        public string Type;

        [DataMember]
        public string SubType;

        [DataMember]
        public int Toughness;

        [DataMember]
        public int Loyalty;

        [DataMember]
        public string Rarity;

        [DataMember]
        public string Artist;

        [DataMember]
        public string CardSetId;

        [DataMember]
        public IEnumerable<Ruling> Rulings;

        [DataMember]
        public IEnumerable<string> Formats;

        [DataMember]
        public DateTime ReleasedAt;
    }
}
