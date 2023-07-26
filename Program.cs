using System.Collections;

namespace _541._Reverse_String_II
{
    internal class Program
    {
        static public string ReverseString(string s)
        {
            string result = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }
            return result;
        }
        static public string ReverseStr(string s, int k)
        {
            string result = string.Empty;
            bool reverse = true;
            for (int i = 0; i < s.Length; i += k)
            {
                if (reverse)
                {
                    result += ReverseString(s.Substring(i, (i + k  > s.Length) ? s.Length - i : k));
                    reverse = false;

                }
                else
                {

                    result += s.Substring(i, (i + k > s.Length) ? s.Length - i : k);
                    reverse = true;
                }
            }

        return result;
        }


                
                

    
        static void Main(string[] args)
        {
            
            string s = "abcdefg";
            //char[] array = { 'a', 'b', 'c', 'd', 'e', 'f' };
            
            /*foreach(var letter in s)
            {
                Console.WriteLine(letter);
            }*/
            Console.WriteLine(ReverseStr(s,3));
        }
    }
}