using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Infrastructure.DomainBase;

namespace Skaele.Domain.Cards
{
    public class Card : Entity
    {
        public Card()
        {
        }

        /*protected Card()
        {
            
        }*/

        [DataMember(Name = "id")]
        public virtual int MultiverseId { get; internal set; }

        public virtual int SetNumber { get; internal set; }

        public virtual string Name { get; internal set; }

        public virtual string SearchName { get; internal set; }

        public virtual string Description { get; internal set; }

        public virtual string Flavor { get; internal set; }

        public virtual IEnumerable<string> Colors { get; internal set; }

        public virtual string Manacost { get; internal set; }

        public virtual string ConvertedManaCost { get; internal set; }

        public virtual string CardSetName { get; internal set; }

        public virtual string Type { get; internal set; }

        public virtual string SubType { get; internal set; }

        public virtual int Power { get; internal set; }

        public virtual int Toughness { get; internal set; }

        public virtual int Loyalty { get; internal set; }

        public virtual string Rarity { get; internal set; }

        public virtual string Artist { get; internal set; }

        public virtual string CardSetId { get; internal set; }

        public virtual IEnumerable<Ruling> Rulings { get; internal set; }

        public virtual IEnumerable<string> Formats { get; internal set; }

        public virtual DateTime ReleasedAt { get; internal set; }
    }
}
