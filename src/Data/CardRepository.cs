using System;
using NHibernate;
using Skaele.Domain.AbstractRepository;
using Skaele.Domain.Cards;

namespace Data
{
    public class CardRepository: BaseRepository<Card>, ICardRepository
    {
        private readonly ISession _session;

        public CardRepository(ISession session)
        {
            _session = session;
        }

        public override ISession Session
        {
            get { return _session; }
        }

        public override void Save(Card card)
        {
            if (card.IsTransient())
            {
                throw new InvalidOperationException("Cannot save card if not created first.");
            }
            base.Save(card);
        }
    }
}
