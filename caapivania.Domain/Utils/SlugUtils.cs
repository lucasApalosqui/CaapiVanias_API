using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caapivania.Domain.Utils
{
    public static class SlugUtils
    {
        public static string With_One_String(string value)
        {
            value = SubSpace(value);
            return value;
        }




        private static string SubSpace(string value) =>
            value.Replace(" ", "-");

    }
}
