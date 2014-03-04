using System;
using System.Collections.Generic;
using Infrastructure.DomainBase;

namespace Skaele.Domain.Cards
{
    public class Card : Entity
    {
        private int _setNumber;
        private string _name;
        private string _searchName;
        private string _description;
        private string _flavor;
        private IEnumerable<string> _colors;
        private string _manacost;
        private string _convertedManaCost;
        private string _cardSetName;
        private int _power;
        private string _type;
        private string _subType;
        private int _toughness;
        private int _loyalty;
        private string _rarity;
        private string _artist;
        private string _cardSetId;
        private IEnumerable<Ruling> _rulings;
        private IEnumerable<string> _formats;
        private DateTime _releasedAt;

        protected Card()
        {
            
        }

        public virtual int SetNumber
        {
            get { return _setNumber; }

        }

        public virtual string Name
        {
            get { return _name; }
        }

        public virtual string SearchName
        {
            get { return _searchName; }
        }

        public virtual string Description
        {
            get { return _description; }
        }

        public virtual string Flavor
        {
            get { return _flavor; }
        }

        public virtual IEnumerable<string> Colors
        {
            get { return _colors; }
        }

        public virtual string Manacost
        {
            get { return _manacost; }
        }

        public virtual string ConvertedManaCost
        {
            get { return _convertedManaCost; }
        }

        public virtual string CardSetName
        {
            get { return _cardSetName; }
        }

        public virtual string Type
        {
            get { return _type; }
        }

        public virtual string SubType
        {
            get { return _subType; }
        }

        public virtual int Power
        {
            get { return _power; }
        }

        public virtual int Toughness
        {
            get { return _toughness; }
        }

        public virtual int Loyalty
        {
            get { return _loyalty; }
        }

        public virtual string Rarity
        {
            get { return _rarity; }
        }

        public virtual string Artist
        {
            get { return _artist; }
        }

        public virtual string CardSetId
        {
            get { return _cardSetId; }
        }

        public virtual IEnumerable<Ruling> Rulings
        {
            get { return _rulings; }
        }

        public virtual IEnumerable<string> Formats
        {
            get { return _formats; }
        }

        public virtual DateTime ReleasedAt
        {
            get { return _releasedAt; }
        }
    }
}
