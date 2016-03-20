using System.Runtime.Serialization;

namespace KnockKnockService
{
    [DataContract]
    public enum TriangleType
    {
        [EnumMember]
        Error = 0,

        [EnumMember]
        Equilateral = 1,

        [EnumMember]
        Isosceles = 2,

        [EnumMember]
        Scalene = 3
    }
}
