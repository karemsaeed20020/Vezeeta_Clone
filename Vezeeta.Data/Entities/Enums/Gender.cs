using System.Runtime.Serialization;

namespace Vezeeta.Data.Entities.Enums
{
    public enum Gender
    {
        [EnumMember(Value = "Male")]
        Male = 1,
        [EnumMember(Value = "Female")]
        Female = 2
    }
}
