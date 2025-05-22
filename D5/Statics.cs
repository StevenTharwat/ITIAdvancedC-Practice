namespace D5
{
    static class Statics
    {
        public static List<char> FindALL(this string s, Predicate<char> pre)
        {
            List<char> chars = [];
            foreach (char ch in s)
            {
                if (pre(ch)) chars.Add(ch);
            }
            return chars;
        }
    }
}
