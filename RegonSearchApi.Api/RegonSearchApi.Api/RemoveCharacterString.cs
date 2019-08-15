using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegonSearchApi.Api
{
    public static class RemoveCharacterString
    {
        public static string RemoveLetterFromNipValue(string value)
        {
            value = Regex.Replace(value, @"^[A-Z]+|\-", "");
            return value.ToString();
        }
    }
}
