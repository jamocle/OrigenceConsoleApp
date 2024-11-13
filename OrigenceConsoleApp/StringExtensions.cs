using System.Runtime.CompilerServices;
using System.Text;

namespace OrigenceConsoleApp;

public static class StringExtensions
{
    public static string RemoveDuplicates(this string src)
    {
        if (src == null) return null;
        if (src == string.Empty) return string.Empty;

        var sb = new StringBuilder();
        var h = new HashSet<char>();

        foreach(var c in src)
        {
            if (!h.Contains(c))
            {
                sb.Append(c);
                h.Add(c);
            }
        }
        return sb.ToString();
    }
}
