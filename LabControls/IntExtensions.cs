
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabControls
{
    public static class IntExtension
    {
        /// <summary>
        /// Возвращает строковое представление объекта типа int, в системе счисления с основанием radix.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="radix"></param>
        /// <returns></returns>
        public static string ToStringWithRadix(this int value, int radix)
        {
            StringBuilder result = new StringBuilder();
            if (value == 0)
            {
                return "0";
            }
            for (int i = 1; value > 0; i++)
            {
                int tmp = (int)Math.Pow(radix, i);
                int digit = (value % tmp) * radix / tmp;
                result.Insert(0, (digit).ToString());
                value = (value / tmp) * tmp;
            }
            return result.ToString();
        }
    }
}
