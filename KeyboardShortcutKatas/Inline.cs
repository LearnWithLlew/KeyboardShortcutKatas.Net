using System;

namespace KeyboardShortcutKatas
{
    public class Inline
    {
        int e = 2;
    
        public int Practice()
        {
            var i = 2;
            var a = 5;
            var s = 2 - i;
            var j = (B() - a + i);
            var m = F(3);
            if (N())
            {
                m += 56;
            }
            Func<int> k = () =>
            {
                var l = m + j;
                return l - C(e);
            };
            var q = 1 - O.Create().p;
            return 42 + k() +q + 7.H() +s;
        }

        private bool N()
        {
            return false;
        }

        private static int F(int G)
        {
            return -3+G;
        }

        private static int C(int d)
        {
            return d;
        }

        private static int B()
        {
            return 5;
        }
    }
    public static class Extenions{

       
        public static int H(this int that)
        {
            return that - 7;
        }
    }

    public class O
    {
        public int p = 1;

        public static O Create()
        {
            return new O();
        }
    }
}