using System;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                if (number == int.MaxValue)
                {
                    return null;
                }
                char[] l = number.ToString().ToCharArray();
                Array.Sort(l);
                char[] lr = new char[l.Length];
                lr = (char[])l.Clone();
                Array.Reverse(lr);
                string g = new string(lr);
                int g1 = Convert.ToInt32(g);
                checked
                {
                    for (int i = number + 1; i <= g1; i++)
                    {
                        char[] ch = i.ToString().ToCharArray();
                        Array.Sort(ch);
                        if (CharArrayCompare(l, ch))
                        {
                            return i;
                        }
                    }
                    return null;
                }
            }
        }
        private static bool CharArrayCompare(char[] charLeft, char[] charRight)
        {
            if (charLeft.Length != charRight.Length)
                return false;
            var length = charLeft.Length;
            for (int i = 0; i < length; i++)
            {
                if (charLeft[i] != charRight[i])
                    return false;
            }
            return true;
        }
    }
}
