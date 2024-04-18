using System.ComponentModel;

namespace AkinsoftExcellOkuma.Client.Utils
{
    public class EnumHelper
    {
        public static List<KeyValuePair<string, int>> GetEnumDescriptionAndValues<T>()
        {
            Type enumType = typeof(T);

            if (enumType.BaseType != typeof(Enum))
                throw new ArgumentException("T is not Enum");

            var result = new List<KeyValuePair<string, int>>();

            foreach (var e in Enum.GetValues(typeof(T)))
            {
                var field = e.GetType().GetField(e.ToString());
                var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

                result.Add(new KeyValuePair<string, int>((attributes.Length > 0) ? attributes[0].Description : e.ToString(), (int)e));
            }

            return result;
        }
    }
}
