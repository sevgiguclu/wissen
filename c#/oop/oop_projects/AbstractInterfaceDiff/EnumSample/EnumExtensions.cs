using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            string displayName;
            //FirstOrDefault birden fazla gelmesin diye kullandık
            //?? nullsa yanındaki yaz demek 
            //? null değer dönebilir hata verme demek
            displayName = enumValue.GetType().GetMember(enumValue.ToString()).FirstOrDefault().GetCustomAttribute<DisplayAttribute>()?.GetName() ?? enumValue.ToString();

            //if(string.IsNullOrEmpty(displayName))
            //    displayName = enumValue.ToString();

            return displayName;
        }

    }

    
}
