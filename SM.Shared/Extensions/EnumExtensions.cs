using System.ComponentModel;
using System.Reflection;

namespace SM.Shared.Extensions
{
    public static class EnumExtensions
    {
        public static string Value(this Enum enumeration)
            => enumeration.GetAttributeValue<DescriptionAttribute, string>(x => x.Description);

        public static string StringValueOfEnum(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        #region [PRIVATE METHODS]
        private static TResult GetAttributeValue<T, TResult>(this Enum enumeration, Func<T, TResult> expression) where T : Attribute
        {
            var item = enumeration.GetType().GetMember(enumeration.ToString())
                .FirstOrDefault(member => member.MemberType == MemberTypes.Field);
            var result = default(TResult);
            if (item == null) return result;
            var attribute = item
                .GetCustomAttributes(typeof(T), false)
                .Cast<T>()
                .SingleOrDefault();
            if (attribute != null)
            {
                result = expression(attribute);
            }
            return result;
        }
        #endregion
    }
}
