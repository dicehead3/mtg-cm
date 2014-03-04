using System;
using System.Runtime.Serialization;

namespace MTG_API
{
    [DataContract]
    public class Ruling
    {
        [DataMember]
        public DateTime ReleasedAt;

        [DataMember]
        public string Rule;
    }
}
