using System.Linq;
using NUnit.Framework;
using Skaele.Domain.Cards;
using Tests.Utils.TestFixtures;

namespace Tests.Unit.Domain
{
    class CardTests: BaseTestFixture
    {
        [Test]
        public void CanCreateCardsFromJson()
        {
            const string json = @" 
    [
        {""id"":1,""setNumber"":6,""name"":""Ankh of Mishra"",""searchName"":""ankhofmishra"",""description"":""Whenever a land enters the battlefield, Ankh of Mishra deals 2 damage to that land's controller."",
        ""flavor"":"""",""colors"":[""None""],""manaCost"":""2"",""convertedManaCost"":2,""cardSetName"":""Limited Edition Alpha"",""type"":""Artifact"",""subType"":null,""power"":0,""toughness"":0,
        ""loyalty"":0,""rarity"":""Rare"",""artist"":""Amy Weber"",""cardImage"":""http://api.mtgdb.info/content/card_images/1.jpeg"",""cardSetId"":""LEA"",
        ""rulings"":[
            {""releasedAt"":""2004-10-04T00:00:00Z"",""rule"":""This triggers on any land entering the battlefield. This includes playing a land or putting a land onto the battlefield using a spell or ability.""},
            {""releasedAt"":""2004-10-04T00:00:00Z"",""rule"":""It determines the land's controller at the time the ability resolves. If the land leaves the battlefield before the ability resolves, the land's last controller before it left is used.""}
        ],""formats"":[""Legacy"",""Vintage"",""Freeform"",""Prismatic"",""Tribal Wars Legacy"",""Classic"",""Singleton 100"",""Commander""],""releasedAt"":""1993-08-05T00:00:00Z""},
        {""id"":2,""setNumber"":12,""name"":""Basalt Monolith"",""searchName"":""basaltmonolith"",""description"":""Basalt Monolith doesn't untap during your untap step.\n{Tap}: Add {3} to your mana pool.{3}: Untap Basalt Monolith."",
        ""flavor"":"""",""colors"":[""None""],""manaCost"":""3"",""convertedManaCost"":3,""cardSetName"":""Limited Edition Alpha"",""type"":""Artifact"",""subType"":null,""power"":0,""toughness"":0,
        ""loyalty"":0,""rarity"":""Uncommon"",""artist"":""Jesper Myrfors"",""cardImage"":""http://api.mtgdb.info/content/card_images/2.jpeg"",""cardSetId"":""LEA"",
        ""rulings"":[
            {""releasedAt"":""2004-10-04T00:00:00Z"",""rule"":""It can be untapped as often as you can pay for it.""}
        ],""formats"":[""Legacy"",""Vintage"",""Commander""],""releasedAt"":""1993-08-05T00:00:00Z""},
        {""id"":3,""setNumber"":18,""name"":""Black Lotus"",""searchName"":""blacklotus"",""description"":""{Tap}, Sacrifice Black Lotus: Add three mana of any one color to your mana pool."",
        ""flavor"":"""",""colors"":[""None""],""manaCost"":""0"",""convertedManaCost"":0,""cardSetName"":""Limited Edition Alpha"",""type"":""Artifact"",""subType"":null,""power"":0,""toughness"":0,
        ""loyalty"":0,""rarity"":""Rare"",""artist"":""Christopher Rush"",""cardImage"":""http://api.mtgdb.info/content/card_images/3.jpeg"",""cardSetId"":""LEA"",""rulings"":[],
        ""formats"":[""Legacy"",""Vintage"",""Commander""],""releasedAt"":""1993-08-05T00:00:00Z""}
    ]";
            var cards = new CardFactory().CreateCardsFromJson(json).ToList();

            Assert.AreEqual(cards.Count(), 3);
            Assert.AreEqual(cards.First().MultiverseId, 1);
        }
    }
}
