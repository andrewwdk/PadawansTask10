using System;

namespace PadawansTask10
{
    public static class NullableTypeExtensions
    {
        public static bool IsNull(this object variable)
        {
            bool result = false;

            if (variable == null)
                result = true;

            return result;
        }
    }
}
