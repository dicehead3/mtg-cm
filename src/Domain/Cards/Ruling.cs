using System;
using Infrastructure.DomainBase;

namespace Skaele.Domain.Cards
{
    public class Ruling
    {
        private readonly DateTime _date;
        private readonly string _rule;

        public Ruling(DateTime date, string rule)
        {
            _date = date;
            _rule = rule;
        }

        protected Ruling ()
        {
            
        }

        public virtual Guid Id { get; protected set; }

        public virtual DateTime Date { get { return _date; } }

        public virtual string Rule { get { return _rule; } }
        
    }
}
