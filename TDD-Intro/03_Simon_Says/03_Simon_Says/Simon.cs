using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Simon_Says
{
    internal class Simon
    {
        private string[] smallWords = {"the", "over", "in", "and"};

        public Simon()
        {
        }

        internal string Echo(string v)
        {
            return v.ToLower();
        }

        internal string Shout(string v)
        {
            return v.ToUpper();
        }

        internal string Repeat(string v)
        {
            return v + " " + v;
        }

        internal string Repeat(string v, int i)
        {
            string s = v;

            while(i-- > 1)
            {
                s += " " + v;
            }

            return s;
        }

        internal string StartOfWord(string v, int i)
        {
            return v.Substring(0,i);
        }

        internal string FirstWord(string v)
        {
            string[] s = v.Split();
            return s[0];
        }

        internal string Titleize(string v)
        {
            List<string> l = new List<string>();

            foreach(string word in v.Split())
            {
                if(smallWords.Contains(word))
                    l.Add(word);
                else
                    l.Add(Capitalize(word));
            }

            return Capitalize(String.Join(" ", l));
        }

        internal string Capitalize(string v)
        {
            return v.Substring(0,1).ToUpper() + v.Substring(1);
        }
    }
}