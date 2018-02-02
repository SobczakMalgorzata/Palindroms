using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Palindroms
    {
        public Palindroms() { }
        public List<string> GetPalindroms(string s, int i)
        {
            List<string> list = new List<string>();

            for (int k = 0; k < s.Length - i; k++)
            {
                char[] word = new char[i];
                for (int l = 0; l<i;l++)
                {
                    word[l] = s[k+l];
                }
                bool palindrom = true;


                for (int j = 0; (i - (2 * j)) > 1; j++)
                {
                    if (palindrom && word[j] == word[i - j - 1])
                    {
                        palindrom = true;
                    }
                    else
                    {
                        palindrom = false;
                    }
                }
                if (palindrom)
                {
                    list.Add(new string(word));
                }
            }
            return list;
        }


        public string GetSmalest(List<string> list)
        {
            int min = Int32.Parse(list[0]);
            string word = list[0];
            foreach (string s in list)
            {
                int next = Int32.Parse(s);
                if (next < min)
                {
                    min = next;
                    word = s;
                }
            }
            return word;
        }
    }
}
