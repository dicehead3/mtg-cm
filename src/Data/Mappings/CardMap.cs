using FluentNHibernate.Mapping;
using Skaele.Domain.Cards;

namespace Data.Mappings
{
    public class CardMap : ClassMap<Card>
    {
        public CardMap()
        {
            Table("Cards");

            Id(x => x.Id);

            Map(x => x.SetNumber)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable();
            Map(x => x.Name)
                .Length(9999)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable();
            Map(x => x.SearchName)
                .Length(9999)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable();
            Map(x => x.Description)
                .Length(9999)
                .Access.CamelCaseField(Prefix.Underscore)
                .Nullable();
            Map(x => x.Flavor)
                .Length(9999)
                .Access.CamelCaseField(Prefix.Underscore)
                .Nullable();
            HasManyToMany(x => x.Colors)
                .Table("Colors")
                .Element("Color")
                .Access.CamelCaseField(Prefix.Underscore)
                .AsSet()
                .Not.LazyLoad();
            Map(x => x.Manacost)
                .Length(9999)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable();
            Map(x => x.ConvertedManaCost)
                .Length(9999)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable();
            Map(x => x.CardSetName)
                .Length(9999)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable();
            Map(x => x.Type)
                .Length(9999)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable();
            Map(x => x.SubType)
                .Length(9999)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable();
            Map(x => x.Power)
                .Access.CamelCaseField(Prefix.Underscore)
                .Nullable();
            Map(x => x.Toughness)
                .Access.CamelCaseField(Prefix.Underscore)
                .Nullable();
            Map(x => x.Loyalty)
                .Access.CamelCaseField(Prefix.Underscore)
                .Nullable();
            Map(x => x.Rarity)
                .Length(9999)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable();
            Map(x => x.Artist)
                .Length(9999)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable();
            Map(x => x.CardSetId)
                .Length(9999)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable();
            HasMany(x => x.Rulings)
                .Table("Rulings")
                .AsSet()
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.LazyLoad();
            HasMany(x => x.Formats)
                .Table("Formats")
                .Element("Format")
                .Access.CamelCaseField(Prefix.Underscore)
                .AsSet()
                .Not.LazyLoad();
            Map(x => x.ReleasedAt)
                .Access.CamelCaseField(Prefix.Underscore)
                .Not.Nullable();
        }
    }

    public class RulingMap : ClassMap<Ruling>
    {
        public RulingMap()
        {
            Table("Rulings");

            Id(x => x.Id);

            Map(x => x.Date)
                .Nullable();

            Map(x => x.Rule)
                .Length(9999)
                .Nullable();
        }
    }
}
