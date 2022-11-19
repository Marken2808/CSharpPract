using System.Text.RegularExpressions;

namespace MAUI.Apps.Framework.Extensions;

public static class StringExtensions
{
    public static string CleanCacheKey(this string uri)
    {
        return Regex.Replace((new Regex("[\\~#%&*{}/:<>?|\"-]")).Replace(uri, " "), @"\s+", "-");
    }
        
}

