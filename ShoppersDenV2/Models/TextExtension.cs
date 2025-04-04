using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV2.Models
{
    static class TextExtension
    {
        public static string[] SplitText(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return Array.Empty<string>();

            return text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
