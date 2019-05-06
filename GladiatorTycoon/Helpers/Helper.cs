using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorTycoon
{
    public static class Helper
    {
        public static T ParseObjectToEnum<T>(object o)
        {
            return (T)Enum.Parse(typeof(T), o.ToString());
        }

        public static bool IsNumber(this object obj)
        {
            if (Equals(obj, null))
            {
                return false;
            }

            Type objType = obj.GetType();
            objType = Nullable.GetUnderlyingType(objType) ?? objType;

            if (objType.IsPrimitive)
            {
                return objType != typeof(bool) &&
                    objType != typeof(char) &&
                    objType != typeof(IntPtr) &&
                    objType != typeof(UIntPtr);
            }

            return objType == typeof(decimal);
        }
    }
}
