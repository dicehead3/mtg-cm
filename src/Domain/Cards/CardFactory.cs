using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace Skaele.Domain.Cards
{
    public class CardFactory
    {
        public IEnumerable<Card> CreateCardsFromJson(string json)
        {
            var serializer = new JavaScriptSerializer
            {
                MaxJsonLength = int.MaxValue
            };

            return serializer.Deserialize<IEnumerable<Card>>(json);
        } 
    }
}
